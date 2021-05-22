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
            KeyPreview = true;
            _facade = new Facade(5, pictureBox.Height, pictureBox.Width);
        }

        /// <summary>
        /// Loads all the music notes files.
        /// </summary>
        private void loadFiles()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(Path);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.wav"); //Getting wav files
                                                        //mai am de rezolva partea cu extensia in plus....
                foreach (FileInfo file in Files)
                {
                    textboxNote.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
                }
            }
            catch
            {
                MessageBox.Show("Imi pare rau, dar fara fisierul de note muzicale, aplicatie e nefolositoare!\n" +
                    "Unde ai executabilul ai nevoie de un folder \"Note\" cu fisiere .wav ca note");
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
                try
                {
                    (string, Color) t = _facade.AddNote(notePath, posX, posY);
                    b.Text = t.Item1;
                    b.BackColor = t.Item2;
                    b.Font = new Font("Arial", 5);
                    Controls.Add(b);
                    b.BringToFront();
                }
                catch
                {
                    MessageBox.Show("Alege o nota mai intai, te rog!\nGasesti in lista din stanga note");
                }
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

        #region Alex: Stergere note de la  tastatura(tasta D) si play la nota respectiva tot de la tastatura(tasta P)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    _facade.DeleteNote(Controls, pictureBox.Bounds.X, pictureBox.Bounds.Y);
                    break;
                case Keys.P:
                    _facade.playANote(Controls, pictureBox.Bounds.X, pictureBox.Bounds.Y);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void buttonExportWav_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogWav.Filter = "WAV File(*.wav)|*.wav";
                saveFileDialogWav.ShowDialog();
                _facade.ExportSimulationAsWAV(saveFileDialogWav.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonLoadSimulation_Click(object sender, EventArgs e)
        {
            openFileDialogLoad.Filter = "Text Files(*.txt)|*.txt";
            if (openFileDialogLoad.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string[] notes = _facade.LoadSimulation(openFileDialogLoad.FileName);
                foreach (Control control in Controls)
                    if (control is Button)
                        Controls.Remove(control);

                for (int i = 2; i < notes.Length; i++)
                {
                    string[] noteData = notes[i].Split('\t');

                    Button b = new Button();

                    int posX = int.Parse(noteData[0]);
                    int posY = int.Parse(noteData[1]);

                    b.Size = new Size(50, 20);
                    b.Location = new Point(pictureBox.Location.X + posX + 5, pictureBox.Location.Y + posY);

                    (string, Color) t = _facade.AddNote(noteData[2].Substring(5), posX, posY);

                    b.Text = t.Item1;
                    b.BackColor = t.Item2;
                    b.Font = new Font("Arial", 5);
                    Controls.Add(b);
                    b.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogWav.Filter = "Text File(*.txt)|*.txt";
                saveFileDialogWav.ShowDialog();
                _facade.SaveSimulation(saveFileDialogWav.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Diagnostics.Process.Start("FLStudio Help File.chm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
