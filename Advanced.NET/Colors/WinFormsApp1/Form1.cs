using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Random voor willekeurige kleuren
        private readonly Random _rng = new Random();

        // Constante grenzen (ms)
        private const int MinMs = 100;   // snelst (fastest)
        private const int MaxMs = 1000;  // traagst (slowest)


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure trackBar bounds exist and give a sensible default
            if (trackBar1 != null)
            {
                trackBar1.Minimum = 0;
                trackBar1.Maximum = 100;
                trackBar1.Value = trackBar1.Maximum; // default to max for immediate color changes if started
            }

            // Default timer interval
            timer1.Interval = MaxMs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Only change color when trackbar is at maximum
            if (trackBar1 != null && trackBar1.Value == trackBar1.Maximum)
            {
                // If no channel is selected, don't change the color
                if (!chkR.Checked && !chkG.Checked && !chkB.Checked)
                    return;

                int r = chkR.Checked ? _rng.Next(256) : 0;
                int g = chkG.Checked ? _rng.Next(256) : 0;
                int b = chkB.Checked ? _rng.Next(256) : 0;

                // Apply the color composed from selected channels
                this.BackColor = Color.FromArgb(r, g, b);
            }
            // If value != Maximum, do nothing on tick (timer keeps running until stopped by Start/Stop)
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateTimerInterval();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimerInterval();
        }

        private void UpdateTimerInterval()
        {
            if (trackBar1 == null) return;

            int min = trackBar1.Minimum;
            int max = trackBar1.Maximum;
            int value = trackBar1.Value;

            if (max == min)
            {
                timer1.Interval = MaxMs;
                return;
            }

            // Map trackBar value linearly to interval between MaxMs (at min) and MinMs (at max).
            double t = (value - min) / (double)(max - min); // 0..1
            int interval = (int)Math.Round(MaxMs - t * (MaxMs - MinMs)); // at t=1 -> MinMs, at t=0 -> MaxMs

            // Clamp to be safe
            if (interval < MinMs) interval = MinMs;
            if (interval > MaxMs) interval = MaxMs;

            timer1.Interval = interval;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
        }

        // Checkbox handlers do not need logic; the timer reads their Checked state each tick.
        private void chkR_CheckedChanged(object sender, EventArgs e) { }
        private void chkG_CheckedChanged(object sender, EventArgs e) { }
        private void chkB_CheckedChanged(object sender, EventArgs e) { }
    }
}
