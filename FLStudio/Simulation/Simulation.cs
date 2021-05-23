/********************************************************************************
 *                                                                              *
 *  File:        Simulation.cs                                                  *
 *  Copyright:   (c) 2021, A.A. Harpa, M.S. Sirghi, A.B. Stoian, A. Zbereanu    *
 *  Description: Contains informations about the play bar.                      *
 *                                                                              *
 *  This code and information is provided "as is" without warranty of any kind, *
 *  either expressed or implied, including but not limited to the implied       *
 *  warranties of merchantability or fitness for a particular purpose. You are  *
 *  free to use this source code in your applications as long as the original   *
 *  copyright notice is included.                                               *
 *                                                                              *
 ********************************************************************************/
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
        /// <summary>
        ///   Getter for the bar object.
        /// </summary>
        public Rectangle Bar
        {
            get { return _bar; }
        }
        /// <summary>
        /// Getter for x position of the bar.
        /// </summary>
        public int GetPlayBarX
        {
            get { return _bar.X; }
        }
        /// <summary>
        /// Getter for bar width.
        /// </summary>
        public int GetPlayBarWidth
        {
            get { return _bar.Width; }
        }
        /// <summary>
        /// Move the bar with an offset.
        /// </summary>
        /// <param name="offset"></param>
        public void MoveBar(int offset)
        {
            _bar.X += offset;
        }
        /// <summary>
        /// Resets the bar to initial position.
        /// </summary>
        public void Reset()
        {
            _bar.X = 0;
        }
        /// <summary>
        /// Getter and setter for  _playSpeed.
        /// </summary>
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
