
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartSimulare
            // 
            this.buttonStartSimulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSimulare.Location = new System.Drawing.Point(32, 15);
            this.buttonStartSimulare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartSimulare.Name = "buttonStartSimulare";
            this.buttonStartSimulare.Size = new System.Drawing.Size(141, 38);
            this.buttonStartSimulare.TabIndex = 0;
            this.buttonStartSimulare.Text = "Start simulare";
            this.buttonStartSimulare.UseVisualStyleBackColor = true;
            this.buttonStartSimulare.Click += new System.EventHandler(this.buttonStartSimulare_Click);
            // 
            // viteza
            // 
            this.viteza.AutoSize = true;
            this.viteza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viteza.Location = new System.Drawing.Point(375, 25);
            this.viteza.Name = "viteza";
            this.viteza.Size = new System.Drawing.Size(48, 18);
            this.viteza.TabIndex = 2;
            this.viteza.Text = "Viteza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarSpeed);
            this.groupBox1.Controls.Add(this.viteza);
            this.groupBox1.Controls.Add(this.buttonStartSimulare);
            this.groupBox1.Location = new System.Drawing.Point(179, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(435, 9);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(187, 56);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textboxNote);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(161, 455);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textboxNote
            // 
            this.textboxNote.FormattingEnabled = true;
            this.textboxNote.ItemHeight = 16;
            this.textboxNote.Location = new System.Drawing.Point(0, 39);
            this.textboxNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxNote.Name = "textboxNote";
            this.textboxNote.Size = new System.Drawing.Size(155, 388);
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
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(180, 70);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(733, 379);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aplicatie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
    }
}

