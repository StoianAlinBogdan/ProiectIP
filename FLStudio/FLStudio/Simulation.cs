using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLStudio
{
    #region Andrei: Simulation Class
    public class Simulation
    {
        private Rectangle _bar;
        private int _playSpeed;

        public Simulation(int width, int height, int x = 0, int y = 0, int playSpeed = 100)
        {
            _bar = new Rectangle(x, y, width, height);
            _playSpeed = playSpeed;
        }

        public Rectangle Bar{
            get { return _bar; }
        }


        public void MoveBar(int offset)
        {
            _bar.X += offset;
        }

        public void Reset()
        {
            _bar.X = 0;
        }

        public int PlaySpeed
        {
            get
            {
                return _playSpeed;
            }

            set => _playSpeed = value;
        }

        public void changeSpeed(int amount)
        {
            _playSpeed += amount;
            if(_playSpeed < 100)
            {
                _playSpeed = 100;
                return;
            }

            if(_playSpeed > 1000)
            {
                _playSpeed = 1000;
                return;
            }
        }
    }
    #endregion
}
