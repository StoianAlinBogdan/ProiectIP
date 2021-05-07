using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLStudio
{
    public partial class Form1 : Form
    {
        private Bitmap _bmp;
        //private static List<List<string>> _notes; //nu e nevoie de asta, cred - vedem cand facem fatada
        private const string Path = "Note\\";
        #region Andrei: PlayBar(Test)
        Simulation _playBar;
        #endregion
        public Form1()
        {
            InitializeComponent();
            loadFiles();
            #region Andrei: Initialize playBar(Test)
            _playBar = new Simulation(5, pictureBox.Height);
            #endregion
        }

        #region Alex

        private void loadFiles()
        {
            DirectoryInfo d = new DirectoryInfo(Path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.mp3"); //Getting mp3 files
            //mai am de rezolva partea cu extensia in plus....
            foreach (FileInfo file in Files)
            {
                textboxNote.Items.Add(file.Name);
            }
        }

        

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // evenimentul de desenare
            _bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(_bmp);
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.Blue));

            g.Clear(Color.White);
            g.DrawLine(pen, 0, 0, pictureBox.Width, 0);
            g.DrawLine(pen, 0, 0, 0, pictureBox.Height);

            #region Andrei: Drawing the bar(Test)
            g.FillRectangle(brush, _playBar.Bar);
            #endregion
            e.Graphics.DrawImage(_bmp, 0, 0);
        }
        #endregion

        #region Bogdan + Simona -> note
        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int relativeX = me.Location.X;
            int relativeY = me.Location.Y;
            int cellColumn = relativeX / 50;
            var cellRow = relativeY / 20;
            Control ac = (Control)sender;

            Point locationOnForm = ac.FindForm().PointToClient(ac.Parent.PointToScreen(ac.Location));
            Button b = new Button();

            #region Andrei: Update(Place the notes so that they don't overlap with the playBar)
            b.Size = new Size(50, 20);
            b.Location = new Point(locationOnForm.X + cellColumn * (b.Width + _playBar.Bar.Width) + _playBar.Bar.Width, locationOnForm.Y + cellRow * 20);
            #endregion
            b.Text = "Do";
            b.BackColor = Color.Red;
            b.Font = new Font("Arial", 5);
            this.Controls.Add(b);
            b.BringToFront();
        }
        #endregion

        #region Andrei: Testing the bar movement
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((_playBar.Bar.X + 55) <= pictureBox.Width)
            {
                _playBar.MoveBar(55);
                pictureBox.Invalidate();
            } else
            {
                timer1.Enabled = false;
                _playBar.Reset();
                pictureBox.Invalidate();
            }

        }
        #endregion

        #region Andrei: Testing the bar movement
        private void buttonStartSimulare_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        #endregion
    }
}
