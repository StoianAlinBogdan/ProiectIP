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
            #region Andrei: Initialize playBar(Test)
            _facade = new Facade(5, pictureBox.Height, pictureBox.Width);
            #endregion
        }

        #region Alex

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
            g.FillRectangle(brush, _facade.PlayBar.Bar);
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
            b.Location = new Point(locationOnForm.X + cellColumn * (b.Width + _facade.PlayBar.GetPlayBarWidth) + _facade.PlayBar.GetPlayBarWidth, locationOnForm.Y + cellRow * 20);
            #endregion

            //Choose the selected note.
            //refactorization starts here
            //trebuie NEAPARAT schimbat apelul metodelor din obiecte returnate din fatada!!!!!!!!!
            //deocamdata am lasat asa ca sa fie ceva functional si care respecta oarecum DP-ul, dar NU se respecta principiul cunoasterii minime!
            string notePath = textboxNote.GetItemText(textboxNote.SelectedItem) + ".wav";
            int posX = cellColumn * 55;
            int posY = cellRow * 25;

            (string, Color) t = _facade.AddNote(notePath, posX, posY);
            b.Text = t.Item1;
            b.BackColor = t.Item2;
            b.Font = new Font("Arial", 5);
            this.Controls.Add(b);
            b.BringToFront();
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            _facade.RunSimulation(timer1, pictureBox.Width);
            pictureBox.Invalidate();
        }

        #region Andrei: Testing the bar movement
        private void buttonStartSimulare_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        #endregion

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
