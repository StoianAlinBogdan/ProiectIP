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
        private const string Path = "Note\\";

        private Facade _facade;
        public Form1()
        {
            InitializeComponent();
            loadFiles();
            _facade = new Facade(5, pictureBox.Height, pictureBox.Width);
        }

        /// <summary>
        /// Loads all the music notes files.
        /// </summary>
        private void loadFiles()
        {
            DirectoryInfo d = new DirectoryInfo(Path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.wav"); //Getting wav files
            //mai am de rezolva partea cu extensia in plus....
            foreach (FileInfo file in Files)
            {
                textboxNote.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
        }

        
        /// <summary>
        /// Randers the play bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            g.FillRectangle(brush, _facade.PlayBar.Bar);
            e.Graphics.DrawImage(_bmp, 0, 0);
        }
        /// <summary>
        /// Places the block notes and links them to the appropriate sound file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int relativeX = me.Location.X;
            int relativeY = me.Location.Y;
            int cellColumn = relativeX / 55;
            var cellRow = relativeY / 20;
            Control ac = (Control)sender;
           
            Point locationOnForm = ac.FindForm().PointToClient(ac.Parent.PointToScreen(ac.Location));
            Button b = new Button();

            b.Size = new Size(50, 20);
            b.Location = new Point(locationOnForm.X + cellColumn * (b.Width + _facade.PlayBar.GetPlayBarWidth) + _facade.PlayBar.GetPlayBarWidth, locationOnForm.Y + cellRow * 20);

            string notePath = textboxNote.GetItemText(textboxNote.SelectedItem) + ".wav";
            int posX = cellColumn * 55;
            int posY = cellRow * 20;

            if (me.Button == MouseButtons.Left)
            {
                (string, Color) t = _facade.AddNote(notePath, posX, posY);
                b.Text = t.Item1;
                b.BackColor = t.Item2;
                b.Font = new Font("Arial", 5);
                Controls.Add(b);
                b.BringToFront();
            }
            else if (me.Button == MouseButtons.Right)
            {

                _facade.DeleteNote(Controls, pictureBox.Bounds.X, pictureBox.Bounds.Y);
            }
        }
        /// <summary>
        /// Starts simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            _facade.RunSimulation(timer1, pictureBox.Width);
            pictureBox.Invalidate();
        }

        private void buttonStartSimulare_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// Change the tempo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            _facade.ChangeSimulationSpeed(trackBarSpeed.Value, timer1);
        }

        private void textboxNote_Click(object sender, EventArgs e)
        {
            pictureBox.Enabled = true;
        }
    }
}
