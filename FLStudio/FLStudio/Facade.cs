using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private List<Note>[] _notes;
        private Simulation _playBar;

        /// <summary>
        /// Init contructor for <c>Facade</c> class.
        /// </summary>
        /// <param name="playBarWidth"></param>
        /// <param name="playBarHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        public Facade(int playBarWidth, int playBarHeight, int pictureBoxWidth)
        {
            _playBar = new Simulation(playBarWidth, playBarHeight);

            int columns = pictureBoxWidth / 55;
            _notes = new List<Note>[columns + 1];
            for (int i = 0; i <= columns; i++)
                _notes[i] = new List<Note>();

            NotesInfo.Init();
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
            string[] props = NotesInfo.Properties[notePath];
            System.Drawing.Color systemColor = System.Drawing.Color.FromName(props[1]);
            Note n = new Note("Note\\" + notePath, new System.Drawing.Point(posX, posY), systemColor);
            _notes[posX / 55].Add(n);
            return (props[0], systemColor);

        }

        #region Alex: Stergere control si nota cand apasam click dreapta pe nota focusata
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
                        foreach (Note note in _notes[x])
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
                foreach (Note n in _notes[(_playBar.GetPlayBarX - 55) / 55])
                {
                    #region Andrei: Possible solution for playing multiple sounds
                    var player = new WMPLib.WindowsMediaPlayer();
                    player.URL = n.PathToNote;
                    #endregion
                }
            }
        }
        /// <summary>
        /// Getter for play bar.
        /// </summary>
        public Simulation PlayBar
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

        public void ChangeSimulationSpeed(int speed, Timer timer)
        {
            timer.Interval += (_playBar.PlaySpeed - speed) * 100;
            _playBar.PlaySpeed = speed;
        }


    }
}
