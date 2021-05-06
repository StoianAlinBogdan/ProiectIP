using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLStudio
{
    public partial class Form1 : Form
    {
        private Bitmap _bmp;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // evenimentul de desenare
            _bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(_bmp);
            Pen pen = new Pen(Color.Black);

            g.Clear(Color.White);
            g.DrawLine(pen, 0, 0, pictureBox.Width, 0);
            g.DrawLine(pen, 0, 0, 0, pictureBox.Height);

            e.Graphics.DrawImage(_bmp, 0, 0);
        }

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
            b.Location = new Point(locationOnForm.X + cellColumn * 50, locationOnForm.Y + cellRow * 20);
            b.Text = "Do";
            b.Size = new Size(50, 20);
            b.BackColor = Color.Red;
            b.Font = new Font("Arial", 5);
            this.Controls.Add(b);
            b.BringToFront();
        }
        #endregion
    }
}
