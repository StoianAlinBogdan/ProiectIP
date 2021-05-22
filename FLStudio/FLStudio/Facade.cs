using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Simulation;

namespace FLStudio
{
    /// <summary>
    /// Class <Facade> implements facade design pattern.
    /// <param name="_notes">A list that contains all the slected notes.</param>
    /// <param name="_playBar">Bar used for playing sounds.</param>
    /// </summary>
    public class Facade
    {
        //private List<Note> _notes = new List<Note>();
        private List<Note.Note>[] _notes;
        private Simulation.Simulation _playBar;

        /// <summary>
        /// Init contructor for <c>Facade</c> class.
        /// </summary>
        /// <param name="playBarWidth"></param>
        /// <param name="playBarHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        public Facade(int playBarWidth, int playBarHeight, int pictureBoxWidth)
        {
            _playBar = new Simulation.Simulation(playBarWidth, playBarHeight);

            int columns = pictureBoxWidth / 55;
            _notes = new List<Note.Note>[columns + 1];
            for (int i = 0; i <= columns; i++)
                _notes[i] = new List<Note.Note>();

            NotesInfo.NotesInfo.Init();
        }
        /// <summary>
        /// Method that add notes to _notes list.
        /// </summary>
        /// <param name="notePath"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <returns></returns>
        public (string, System.Drawing.Color) AddNote(string notePath, int posX, int posY)
        {
            try
            {
                string[] props = NotesInfo.NotesInfo.Properties[notePath];
                System.Drawing.Color systemColor = System.Drawing.Color.FromName(props[1]);
                Note.Note n = new Note.Note("Note\\" + notePath, new System.Drawing.Point(posX, posY), systemColor);
                _notes[posX / 55].Add(n);
                return (props[0], systemColor);
            }
            catch(KeyNotFoundException ex)
            {
                throw new Exception("\nCalea notei este incorecta sau nu exista." );
            }
         
            
        }

        #region Alex: Stergere control si nota cand apasam tasta D
        /// <summary>
        /// Remove a note block.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="pictureBoxX"></param>
        /// <param name="pictureBoxY"></param>
        public void DeleteNote(Control.ControlCollection controls, int pictureBoxX, int pictureBoxY)
        {

            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    if (control.Focused)
                    {
                        int x = (control.Location.X - pictureBoxX) / 55;
                        int y = (control.Location.Y - pictureBoxY);
                        foreach (Note.Note note in _notes[x])
                        {
                            if (note.YPosition == y)
                            {
                                _notes[x].Remove(note);
                                controls.Remove((Control)control);
                                break;
                            }
                        }

                    }
                }
            }
        }
        /// <summary>
        /// Play a note block.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="pictureBoxX"></param>
        /// <param name="pictureBoxY"></param>
        public void playANote(Control.ControlCollection controls, int pictureBoxX, int pictureBoxY)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    if (control.Focused)
                    {
                        int x = (control.Location.X - pictureBoxX) / 55;
                        int y = (control.Location.Y - pictureBoxY);
                        foreach (Note.Note note in _notes[x])
                        {
                            if (note.YPosition == y)
                            {
                                var player = new WMPLib.WindowsMediaPlayer();
                                player.URL = note.PathToNote;
                                break;
                            }
                        }

                    }
                }
            }
        }


        #endregion
        /// <summary>
        /// Updates the bar position and checks for collision.
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="width"></param>
        public void RunSimulation(System.Windows.Forms.Timer timer, int width)
        {
            if ((_playBar.GetPlayBarX + 55) <= width)
            {
                _playBar.MoveBar(55);

            }
            else
            {
                timer.Enabled = false;
                ResetBar();
            }
            Collision();

        }
        /// <summary>
        /// Checks for collisions between bar and block notes.
        /// </summary>
        private void Collision()
        {
            if (_playBar.GetPlayBarX < 55 * _notes.Length && _playBar.GetPlayBarX > 0)
            {
                foreach (Note.Note n in _notes[(_playBar.GetPlayBarX - 55) / 55])
                {
                    var player = new WMPLib.WindowsMediaPlayer();
                    player.URL = n.PathToNote;
                }
            }
        }
        /// <summary>
        /// Getter for play bar.
        /// </summary>
        public Simulation.Simulation PlayBar
        {
            get
            {
                return _playBar;
            }
        }
        /// <summary>
        /// Set the bar at the initial position.
        /// </summary>
        public void ResetBar()
        {
            _playBar.Reset();
        }
        /// <summary>
        /// Update the tempo.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="timer"></param>
        /// <returns></returns>
        public bool ChangeSimulationSpeed(int speed, Timer timer)
        {
            if (speed <= 0)
                return false;

            timer.Interval += (_playBar.PlaySpeed - speed) * 100;
            _playBar.PlaySpeed = speed;
            return true;
        }
        /// <summary>
        /// Export simulation as .wav file.
        /// </summary>
        /// <param name="path"></param>
        public void ExportSimulationAsWAV(string path)
        {
            List<AudioFileReader> readers = new List<AudioFileReader>();
            List<MixingSampleProvider> mixers = new List<MixingSampleProvider>();
            try
            {
                foreach (List<Note.Note> columnNotes in _notes)
                {
                    foreach (Note.Note note in columnNotes)
                    {
                        readers.Add(new AudioFileReader(note.PathToNote));
                    }
                    mixers.Add(new MixingSampleProvider(readers));
                }
                ConcatenatingSampleProvider csp = new ConcatenatingSampleProvider(mixers);
                WaveFileWriter.CreateWaveFile(path, csp.ToWaveProvider16());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Save an editable simulation file.
        /// </summary>
        /// <param name="path"></param>
        public void SaveSimulation(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine("fl_simulation_ip");
                foreach (List<Note.Note> columnNotes in _notes)
                {
                    foreach (Note.Note note in columnNotes)
                    {
                        string entry = note.XPosition + "\t" + note.YPosition + "\t" + note.PathToNote;
                        sw.WriteLine(entry);
                    }
                }
                sw.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        /// <summary>
        /// Load an editable simulation file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string[] LoadSimulation(string path, string key = "fl_simulation_ip")
        {
            string[] lines = null;
            lines = File.ReadAllLines(path, Encoding.UTF8);

            if (lines[0] != key)
            {
                throw new Exception("File with unknown header!");
            }

            foreach (List<Note.Note> columnNotes in _notes)
                columnNotes.Clear();


            return lines;
        }
    }
}
