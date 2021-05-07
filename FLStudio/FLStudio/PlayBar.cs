using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLStudio
{
    #region Andrei: PlayBar Class
    public class PlayBar
    {
        private Rectangle _bar;

        public PlayBar(int width, int height, int x = 0, int y = 0)
        {
            _bar = new Rectangle(x, y, width, height);
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
    }
    #endregion
}
