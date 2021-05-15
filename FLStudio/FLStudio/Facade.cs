using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FLStudio
{
public class Facade
    {
        private List<Note> _notes = new List<Note>();
        private Simulation _playBar;

        public Facade(int playBarWidth, int playBarHeight)
        {
            _playBar = new Simulation(playBarWidth, playBarHeight);
            NotesInfo.Init();
        }

        public (string, System.Drawing.Color) addNote(string notePath, int posX, int posY) //functia instantiaza o nota, o adauga la lista, apoi returneaza textul si culoarea pentru buton
        {
            string[] props = NotesInfo.Properties[notePath];
            System.Drawing.Color systemColor = System.Drawing.Color.FromName(props[1]);
            Note n = new Note("Note\\" + notePath, new System.Drawing.Point(posX, posY), systemColor);
            _notes.Add(n);
            return (props[0], systemColor); //asta chiar respecta PCM, pentru ca clientul stie doar de addNote si addNote returneaza doar pentru client
                                            //si cam asa trebuie facut si pentru playbar

        }
        public void runSimulation(System.Windows.Forms.Timer timer, int width)
        {
            if ((_playBar.GetPlayBarX + 55) <= width)
            {
                _playBar.MoveBar(55);

            }
            else
            {
                timer.Enabled = false;
                resetBar();
            }
            collision();

        }

        public void collision()
        {
            foreach (Note n in _notes)
            {
                if (_playBar.GetPlayBarX == n.XPosition+55) 
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

        public void resetBar()
        {
            _playBar.Reset();
        }
    }
}
