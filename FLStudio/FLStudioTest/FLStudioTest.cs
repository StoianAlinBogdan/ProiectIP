using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FLStudio;
using System.IO;

namespace FLStudioTest
{
    [TestClass]
    public class FLStudioTest
    {
        private static Facade _facade = new Facade(5, 320, 550);

        [TestMethod]
        public void Test_LoadSimulation_7_Lines()
        {
            Assert.AreEqual(7, _facade.LoadSimulation("Test\\test2.txt").Length);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Test_LoadSimulation_Unexisting_File()
        {
            _facade.LoadSimulation("Test\\test11.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_LoadSimulation_Wrong_File_Header()
        {
            _facade.LoadSimulation("Test\\test1.txt");
        }

        [TestMethod]
        public void Test_Number_Of_WAV_Files()
        {
            string path = Path.Combine(Directory.GetCurrent‌​Directory(), "..\\..\\..\\FLStudio\\bin\\Debug\\Note");
            DirectoryInfo dir = new DirectoryInfo(path);
            
            Assert.AreEqual(NotesInfo.NotesInfo.Properties.Count, dir.GetFiles().Length);
        }

        [TestMethod]
        public void Test_Note_A_Color()
        {
            Assert.AreEqual("Red" , NotesInfo.NotesInfo.Properties["a3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_A_Diez_Color()
        {
            Assert.AreEqual("Orange", NotesInfo.NotesInfo.Properties["a-3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_B_Color()
        {
            Assert.AreEqual("Blue", NotesInfo.NotesInfo.Properties["b3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_C_Color()
        {
            Assert.AreEqual("Lavender", NotesInfo.NotesInfo.Properties["c3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_C_Diez_Color()
        {
            Assert.AreEqual("MediumPurple", NotesInfo.NotesInfo.Properties["c-3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_D_Color()
        {
            Assert.AreEqual("Green", NotesInfo.NotesInfo.Properties["d3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_D_Diez_Color()
        {
            Assert.AreEqual("LightGreen", NotesInfo.NotesInfo.Properties["d-3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_E_Color()
        {
            Assert.AreEqual("Yellow", NotesInfo.NotesInfo.Properties["e3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_F_Color()
        {
            Assert.AreEqual("Pink", NotesInfo.NotesInfo.Properties["f3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_F_Diez_Color()
        {
            Assert.AreEqual("LightPink", NotesInfo.NotesInfo.Properties["f-3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_G_Color()
        {
            Assert.AreEqual("Cyan", NotesInfo.NotesInfo.Properties["g3.wav"][1]);
        }

        [TestMethod]
        public void Test_Note_G_Diez_Color()
        {
            Assert.AreEqual("LightCyan", NotesInfo.NotesInfo.Properties["g-3.wav"][1]);
        }
    }
}
