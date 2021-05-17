using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLStudio
{
public class Facade
    {
        //private List<Note> _notes = new List<Note>();
        private List<Note>[] _notes;
        private Simulation _playBar;

        public Facade(int playBarWidth, int playBarHeight, int pictureBoxWidth)
        {
            _playBar = new Simulation(playBarWidth, playBarHeight);

            int columns = pictureBoxWidth / 55;
            _notes = new List<Note>[columns + 1];
            for (int i = 0; i <= columns; i++)
                _notes[i] = new List<Note>();

            NotesInfo.Init();
        }

        public (string, System.Drawing.Color) AddNote(string notePath, int posX, int posY) //functia instantiaza o nota, o adauga la lista, apoi returneaza textul si culoarea pentru buton
        {
            string[] props = NotesInfo.Properties[notePath];
            System.Drawing.Color systemColor = System.Drawing.Color.FromName(props[1]);
            Note n = new Note("Note\\" + notePath, new System.Drawing.Point(posX, posY), systemColor);
            _notes[posX / 55].Add(n);
            return (props[0], systemColor); //asta chiar respecta PCM, pentru ca clientul stie doar de addNote si addNote returneaza doar pentru client
                                            //si cam asa trebuie facut si pentru playbar

        }
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

        public Simulation PlayBar
        {
            get
            {
                return _playBar;
            }
        }

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
