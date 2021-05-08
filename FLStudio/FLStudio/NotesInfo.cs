using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLStudio
{
    class NotesInfo
    {
        #region Simona: Dictionary with properties notes.
        public static Dictionary<string, string[]> Init()
        {
            Dictionary<string, string[]> propertiesNotes = new Dictionary<string, string[]>();

            propertiesNotes.Add("a3.mp3", new string[] { "LA", "Red"});
            propertiesNotes.Add("a-3.mp3", new string[] { "LA", "Orange"});
            propertiesNotes.Add("a4.mp3", new string[] { "LA", "Red" });
            propertiesNotes.Add("a-4.mp3", new string[] { "LA", "Orange" });
            propertiesNotes.Add("a5.mp3", new string[] { "LA", "Red" });
            propertiesNotes.Add("a-5.mp3", new string[] { "LA", "Orange" });

            propertiesNotes.Add("b3.mp3", new string[] { "SI", "Blue" });
            propertiesNotes.Add("b4.mp3", new string[] { "SI", "MediumBlue" });
            propertiesNotes.Add("b5.mp3", new string[] { "SI", "LightBlue" });

            propertiesNotes.Add("c3.mp3", new string[] { "DO", "Lavender" });
            propertiesNotes.Add("c-3.mp3", new string[] { "DO", "MediumPurple" });
            propertiesNotes.Add("c4.mp3", new string[] { "DO", "Lavender" });
            propertiesNotes.Add("c-4.mp3", new string[] { "DO", "MediumPurple" });
            propertiesNotes.Add("c5.mp3", new string[] { "DO", "Lavender" });
            propertiesNotes.Add("c-5.mp3", new string[] { "DO", "MediumPurple" });
            propertiesNotes.Add("c6.mp3", new string[] { "DO", "Lavender" });

            propertiesNotes.Add("d3.mp3", new string[] { "RE", "Green" });
            propertiesNotes.Add("d-3.mp3", new string[] { "RE", "LightGreen" });
            propertiesNotes.Add("d4.mp3", new string[] { "RE", "Green" });
            propertiesNotes.Add("d-4.mp3", new string[] { "RE", "LightGreen" });
            propertiesNotes.Add("d5.mp3", new string[] { "RE", "Green" });
            propertiesNotes.Add("d-5.mp3", new string[] { "RE", "LightGreen" });

            propertiesNotes.Add("e3.mp3", new string[] { "MI", "Yellow" });
            propertiesNotes.Add("e4.mp3", new string[] { "MI", "LightYellow" });
            propertiesNotes.Add("e5.mp3", new string[] { "MI", "YellowGreen " });

            propertiesNotes.Add("f3.mp3", new string[] { "FA", "Pink" });
            propertiesNotes.Add("f-3.mp3", new string[] { "FA", "LightPink" });
            propertiesNotes.Add("f4.mp3", new string[] { "FA", "Pink" });
            propertiesNotes.Add("f-4.mp3", new string[] { "FA", "LightPink" });
            propertiesNotes.Add("f5.mp3", new string[] { "FA", "Pink" });
            propertiesNotes.Add("f-5.mp3", new string[] { "FA", "LightPink" });


            propertiesNotes.Add("g3.mp3", new string[] { "SOL", "Cyan" });
            propertiesNotes.Add("g-3.mp3", new string[] { "SOL", "LightCyan" });
            propertiesNotes.Add("g4.mp3", new string[] { "SOL", "Cyan" });
            propertiesNotes.Add("g-4.mp3", new string[] { "SOL", "LightCyan" });
            propertiesNotes.Add("g5.mp3", new string[] { "SOL", "Cyan" });
            propertiesNotes.Add("g-5.mp3", new string[] { "SOL", "LightCyan" });


            return propertiesNotes;

        }
        #endregion
    }
}
