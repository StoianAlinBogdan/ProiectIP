using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLStudio
{
public class Note
    {
        private Point _position;
        private string _pathToNote;
        private Color _noteColor;

        public Note(string path, Point position, Color color)
        {
            _position = position;
            _pathToNote = path;
            _noteColor = color;
        }
    }
}
