/********************************************************************************
 *                                                                              *
 *  File:        NotesInfo.cs                                                   *
 *  Copyright:   (c) 2021, A.A. Harpa, M.S. Sirghi, A.B. Stoian, A. Zbereanu    *
 *  Description: Contains informations of a block note: path, name and color.   *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesInfo
{
    /// <summary>
    /// Class <c>NotesInfo</c> returns details about the available notes.
    /// <param name="_propertiesNotes">Contains all the infromations of a note.</param>
    /// </summary>
    public static class NotesInfo
    {
        private static Dictionary<string, string[]> _propertiesNotes = new Dictionary<string, string[]>();
        public static void Init()
        {
                _propertiesNotes.Add("a3.wav", new string[] { "LA", "Red" });
                _propertiesNotes.Add("a-3.wav", new string[] { "LA", "Orange" });
                _propertiesNotes.Add("a4.wav", new string[] { "LA", "Red" });
                _propertiesNotes.Add("a-4.wav", new string[] { "LA", "Orange" });
                _propertiesNotes.Add("a5.wav", new string[] { "LA", "Red" });
                _propertiesNotes.Add("a-5.wav", new string[] { "LA", "Orange" });

                _propertiesNotes.Add("b3.wav", new string[] { "SI", "Blue" });
                _propertiesNotes.Add("b4.wav", new string[] { "SI", "MediumBlue" });
                _propertiesNotes.Add("b5.wav", new string[] { "SI", "LightBlue" });

                _propertiesNotes.Add("c3.wav", new string[] { "DO", "Lavender" });
                _propertiesNotes.Add("c-3.wav", new string[] { "DO", "MediumPurple" });
                _propertiesNotes.Add("c4.wav", new string[] { "DO", "Lavender" });
                _propertiesNotes.Add("c-4.wav", new string[] { "DO", "MediumPurple" });
                _propertiesNotes.Add("c5.wav", new string[] { "DO", "Lavender" });
                _propertiesNotes.Add("c-5.wav", new string[] { "DO", "MediumPurple" });
                _propertiesNotes.Add("c6.wav", new string[] { "DO", "Lavender" });

                _propertiesNotes.Add("d3.wav", new string[] { "RE", "Green" });
                _propertiesNotes.Add("d-3.wav", new string[] { "RE", "LightGreen" });
                _propertiesNotes.Add("d4.wav", new string[] { "RE", "Green" });
                _propertiesNotes.Add("d-4.wav", new string[] { "RE", "LightGreen" });
                _propertiesNotes.Add("d5.wav", new string[] { "RE", "Green" });
                _propertiesNotes.Add("d-5.wav", new string[] { "RE", "LightGreen" });

                _propertiesNotes.Add("e3.wav", new string[] { "MI", "Yellow" });
                _propertiesNotes.Add("e4.wav", new string[] { "MI", "LightYellow" });
                _propertiesNotes.Add("e5.wav", new string[] { "MI", "YellowGreen " });

                _propertiesNotes.Add("f3.wav", new string[] { "FA", "Pink" });
                _propertiesNotes.Add("f-3.wav", new string[] { "FA", "LightPink" });
                _propertiesNotes.Add("f4.wav", new string[] { "FA", "Pink" });
                _propertiesNotes.Add("f-4.wav", new string[] { "FA", "LightPink" });
                _propertiesNotes.Add("f5.wav", new string[] { "FA", "Pink" });
                _propertiesNotes.Add("f-5.wav", new string[] { "FA", "LightPink" });


                _propertiesNotes.Add("g3.wav", new string[] { "SOL", "Cyan" });
                _propertiesNotes.Add("g-3.wav", new string[] { "SOL", "LightCyan" });
                _propertiesNotes.Add("g4.wav", new string[] { "SOL", "Cyan" });
                _propertiesNotes.Add("g-4.wav", new string[] { "SOL", "LightCyan" });
                _propertiesNotes.Add("g5.wav", new string[] { "SOL", "Cyan" });
                _propertiesNotes.Add("g-5.wav", new string[] { "SOL", "LightCyan" });

        }
        /// <summary>
        /// Getter for properties note.
        /// </summary>
        public static Dictionary<string, string[]> Properties
        {
            get
            {
                return _propertiesNotes;
            }
        }
    }
}
