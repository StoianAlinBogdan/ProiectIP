
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viteza = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxNote = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartSimulare
            // 
            this.buttonStartSimulare.Location = new System.Drawing.Point(9, 9);
            this.buttonStartSimulare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartSimulare.Name = "buttonStartSimulare";
            this.buttonStartSimulare.Size = new System.Drawing.Size(86, 20);
            this.buttonStartSimulare.TabIndex = 0;
            this.buttonStartSimulare.Text = "Start simulare";
            this.buttonStartSimulare.UseVisualStyleBackColor = true;
            this.buttonStartSimulare.Click += new System.EventHandler(this.buttonStartSimulare_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            // 
            // viteza
            // 
            this.viteza.AutoSize = true;
            this.viteza.Location = new System.Drawing.Point(151, 12);
            this.viteza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viteza.Name = "viteza";
            this.viteza.Size = new System.Drawing.Size(36, 13);
            this.viteza.TabIndex = 2;
            this.viteza.Text = "Viteza";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(135, 57);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(465, 316);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viteza);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonStartSimulare);
            this.groupBox1.Location = new System.Drawing.Point(134, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(465, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textboxNote);
            this.groupBox2.Location = new System.Drawing.Point(9, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(121, 370);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textboxNote
            // 
            this.textboxNote.FormattingEnabled = true;
            this.textboxNote.Location = new System.Drawing.Point(0, 32);
            this.textboxNote.Margin = new System.Windows.Forms.Padding(2);
            this.textboxNote.Name = "textboxNote";
            this.textboxNote.Size = new System.Drawing.Size(117, 316);
            this.textboxNote.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Aplicatie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartSimulare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label viteza;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox textboxNote;
        private System.Windows.Forms.Timer timer1;
    }
}

