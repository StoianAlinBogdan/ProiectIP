
namespace FLStudio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStartSimulare = new System.Windows.Forms.Button();
            this.viteza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxNote = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonExportWav = new System.Windows.Forms.Button();
            this.saveFileDialogWav = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLoadSimulation = new System.Windows.Forms.Button();
            this.buttonSaveSimulation = new System.Windows.Forms.Button();
            this.saveFileDialogSimulation = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartSimulare
            // 
            this.buttonStartSimulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSimulare.Location = new System.Drawing.Point(23, 17);
            this.buttonStartSimulare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartSimulare.Name = "buttonStartSimulare";
            this.buttonStartSimulare.Size = new System.Drawing.Size(106, 31);
            this.buttonStartSimulare.TabIndex = 0;
            this.buttonStartSimulare.Text = "Start Simulation";
            this.buttonStartSimulare.UseVisualStyleBackColor = true;
            this.buttonStartSimulare.Click += new System.EventHandler(this.buttonStartSimulare_Click);
            // 
            // viteza
            // 
            this.viteza.AutoSize = true;
            this.viteza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viteza.Location = new System.Drawing.Point(357, 28);
            this.viteza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viteza.Name = "viteza";
            this.viteza.Size = new System.Drawing.Size(43, 15);
            this.viteza.TabIndex = 2;
            this.viteza.Text = "Speed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarSpeed);
            this.groupBox1.Controls.Add(this.viteza);
            this.groupBox1.Controls.Add(this.buttonStartSimulare);
            this.groupBox1.Location = new System.Drawing.Point(134, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(550, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(405, 12);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(140, 45);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textboxNote);
            this.groupBox2.Location = new System.Drawing.Point(9, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(121, 387);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textboxNote
            // 
            this.textboxNote.FormattingEnabled = true;
            this.textboxNote.Location = new System.Drawing.Point(4, 43);
            this.textboxNote.Margin = new System.Windows.Forms.Padding(2);
            this.textboxNote.Name = "textboxNote";
            this.textboxNote.Size = new System.Drawing.Size(113, 329);
            this.textboxNote.TabIndex = 0;
            this.textboxNote.Click += new System.EventHandler(this.textboxNote_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(134, 67);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(550, 320);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveSimulation);
            this.groupBox3.Controls.Add(this.buttonLoadSimulation);
            this.groupBox3.Controls.Add(this.buttonExit);
            this.groupBox3.Controls.Add(this.buttonExportWav);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // buttonExportWav
            // 
            this.buttonExportWav.Location = new System.Drawing.Point(145, 34);
            this.buttonExportWav.Name = "buttonExportWav";
            this.buttonExportWav.Size = new System.Drawing.Size(106, 27);
            this.buttonExportWav.TabIndex = 0;
            this.buttonExportWav.Text = "Export as .wav";
            this.buttonExportWav.UseVisualStyleBackColor = true;
            this.buttonExportWav.Click += new System.EventHandler(this.buttonExportWav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(6, 34);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 27);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLoadSimulation
            // 
            this.buttonLoadSimulation.Location = new System.Drawing.Point(409, 34);
            this.buttonLoadSimulation.Name = "buttonLoadSimulation";
            this.buttonLoadSimulation.Size = new System.Drawing.Size(96, 27);
            this.buttonLoadSimulation.TabIndex = 2;
            this.buttonLoadSimulation.Text = "Load Simulation";
            this.buttonLoadSimulation.UseVisualStyleBackColor = true;
            this.buttonLoadSimulation.Click += new System.EventHandler(this.buttonLoadSimulation_Click);
            // 
            // buttonSaveSimulation
            // 
            this.buttonSaveSimulation.Location = new System.Drawing.Point(283, 34);
            this.buttonSaveSimulation.Name = "buttonSaveSimulation";
            this.buttonSaveSimulation.Size = new System.Drawing.Size(97, 27);
            this.buttonSaveSimulation.TabIndex = 3;
            this.buttonSaveSimulation.Text = "Save Simulation";
            this.buttonSaveSimulation.UseVisualStyleBackColor = true;
            this.buttonSaveSimulation.Click += new System.EventHandler(this.buttonSaveSimulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Aplicatie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartSimulare;
        private System.Windows.Forms.Label viteza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox textboxNote;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExportWav;
        private System.Windows.Forms.SaveFileDialog saveFileDialogWav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLoadSimulation;
        private System.Windows.Forms.Button buttonSaveSimulation;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSimulation;
    }
}

