using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLStudio
{
    /// <summary>
    /// Class <c>Note</c> hold the informations about a musical note.
    /// <param name="_position">Coords of a note block.</param>
    /// <param name="_pathToNote">Path to a particular sound.</param>
    /// <param name="_noteColor">Color of a note block.</param>
    /// </summary>
    public class Note
    {
        private Point _position;
        private string _pathToNote;
        private Color _noteColor;

        /// <summary>
        /// Init constructor of a Note class. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="position"></param>
        /// <param name="color"></param>
        public Note(string path, Point position, Color color)
        {
            _position = position;
            _pathToNote = path;
            _noteColor = color;
        }

        /// <summary>
        /// Getter for x position of a note.
        /// </summary>
        public int XPosition
        {
            get
            {
                return _position.X;
            }
        }

        public int YPosition
        {
            get
            {
                return _position.Y;
            }
        }

        /// <summary>
        /// Getter for path note.
        /// </summary>
        public string PathToNote
        {
            get
            {
                return _pathToNote;
            }
        }
    }
}
