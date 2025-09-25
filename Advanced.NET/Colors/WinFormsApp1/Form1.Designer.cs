namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnStop = new Button();
            chkR = new CheckBox();
            chkG = new CheckBox();
            chkB = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(83, 119);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(245, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Location = new Point(333, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.Location = new Point(333, 69);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // chkR
            // 
            chkR.AutoSize = true;
            chkR.Location = new Point(34, 194);
            chkR.Name = "chkR";
            chkR.Size = new Size(40, 24);
            chkR.TabIndex = 3;
            chkR.Text = "R";
            chkR.UseVisualStyleBackColor = true;
            chkR.CheckedChanged += chkR_CheckedChanged;
            // 
            // chkG
            // 
            chkG.AutoSize = true;
            chkG.Location = new Point(83, 194);
            chkG.Name = "chkG";
            chkG.Size = new Size(41, 24);
            chkG.TabIndex = 4;
            chkG.Text = "G";
            chkG.UseVisualStyleBackColor = true;
            chkG.CheckedChanged += chkG_CheckedChanged;
            // 
            // chkB
            // 
            chkB.AutoSize = true;
            chkB.Location = new Point(129, 194);
            chkB.Name = "chkB";
            chkB.Size = new Size(40, 24);
            chkB.TabIndex = 5;
            chkB.Text = "B";
            chkB.UseVisualStyleBackColor = true;
            chkB.CheckedChanged += chkB_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(439, 284);
            Controls.Add(chkB);
            Controls.Add(chkG);
            Controls.Add(chkR);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "RGB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnStop;
        private CheckBox chkR;
        private CheckBox chkG;
        private CheckBox chkB;
    }
}
