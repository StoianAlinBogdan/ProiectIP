using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    /// <summary>
    /// Class <c>Simulation</c> controls and properties for the play bar.
    /// <param name="_bar">Rectangle object that represent the bar.</param>
    /// <param name="_playSpeed">Represent the tempo.</param>
    /// </summary>
    public class Simulation
    {
        private Rectangle _bar;
        private int _playSpeed;

        /// <summary>
        /// Init constructor for <c>Simulation</c> class.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="playSpeed"></param>
        public Simulation(int width, int height, int x = 0, int y = 0, int playSpeed = 1)
        {
            _bar = new Rectangle(x, y, width, height);
            _playSpeed = playSpeed;
        }

        public Rectangle Bar
        {
            get { return _bar; }
        }

        public int GetPlayBarX
        {
            get { return _bar.X; }
        }

        public int GetPlayBarWidth
        {
            get { return _bar.Width; }
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
    }
}
