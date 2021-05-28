using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TuyamaKeyPresser
{
    public partial class Form1 : Form
    {
        public bool needConfigSave = false;
        public bool appStarted = false;

        public Form1()
        {
            InitializeComponent();

            nmInterval.Value = Program.appConfig.Interval;
            txtProcName.Text = Program.appConfig.ProcessName;
            txtKeyCode.Text = Program.appConfig.KeyCode;
            lblIntervalPreview.Text = GetTimeString((int)nmInterval.Value);

            if (Program.configLoaded)
            {
                lblConfigStatus.Text = "Saved";
                lblConfigStatus.ForeColor = Color.DarkGreen;
            }

            nmInterval.ValueChanged += NmInterval_ValueChanged;

            appStarted = true;
        }

        private void NmInterval_ValueChanged(object sender, EventArgs e)
        {
            lblIntervalPreview.Text = GetTimeString((int)nmInterval.Value);
;        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(txtProcName.Text);

            foreach (Process proc in processes)
            {
                Program.SetForegroundWindow(proc.MainWindowHandle);
                SendKeys.SendWait("{"+ txtKeyCode.Text +"}");
            }
        }

        private void btControl_Click(object sender, EventArgs e)
        {
            // Activate keypresser timer
            if (btControl.Text == "Start")
            {
                // Prevent bugs
                btControl.Enabled = false;
                btControl.Text = "Stop";

                // Disable controls while executing
                DisableControls();

                // Save config if needed
                if (needConfigSave)
                {
                    if (Program.appConfig.Save())
                    {
                        lblConfigStatus.Text = "Saved";
                        lblConfigStatus.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        lblConfigStatus.Text = "Error";
                        lblConfigStatus.ForeColor = Color.DarkRed;
                    }
                }

                // Start key presser
                tmrDelay.Interval = Program.appConfig.Interval * 1000;
                tmrDelay.Start();

                lblTimerStatus.Text = "Running";
                lblTimerStatus.ForeColor = Color.DarkGreen;

                // Let the user cancel process
                btControl.Enabled = true;
            }
            else // Stop keypresser timer
            {
                // Prevent bugs
                btControl.Enabled = false;
                btControl.Text = "Start";

                // Stop key presser
                tmrDelay.Stop();

                lblTimerStatus.Text = "Inactive";
                lblTimerStatus.ForeColor = Color.DarkOrange;

                // Enable controls while stopped
                EnableControls();

                // Let the user start process again
                btControl.Enabled = true;
            }
        }

        private void DisableControls()
        {
            nmInterval.Enabled = false;
            txtProcName.Enabled = false;
            txtKeyCode.Enabled = false;
            lblIntervalPreview.Enabled = false;
        }

        private void EnableControls()
        {
            nmInterval.Enabled = true;
            txtProcName.Enabled = true;
            txtKeyCode.Enabled = true;
            lblIntervalPreview.Enabled = true;
        }

        private string GetTimeString(int time)
        {
            string timeLabel = "???";

            TimeSpan t = TimeSpan.FromSeconds(time);

            // Seconds
            if (time < 60)
            {
                timeLabel = $"{time}s";
            }

            // Minutes
            else if (time < 3600)
            {
                if (t.Seconds == 0)
                {
                    timeLabel = string.Format("{0}m",
                    t.Minutes);
                }
                else
                {
                    timeLabel = string.Format("{0}m {1}s",
                    t.Minutes,
                    t.Seconds);
                }
            }
            else
            {
                if (t.Seconds > 0 && t.Minutes > 0)
                {
                    timeLabel = string.Format("{0}h {1}m {2}s",
                    t.Hours,
                    t.Minutes,
                    t.Seconds);
                }
                else if (t.Minutes > 0)
                {
                    timeLabel = string.Format("{0}h {1}m",
                    t.Hours,
                    t.Minutes);
                }
                else if (t.Seconds > 0)
                {
                    timeLabel = string.Format("{0}h {1}s",
                    t.Hours,
                    t.Seconds);
                }
                else
                {
                    timeLabel = string.Format("{0}h",
                    t.Hours);
                }
            }

            return "= " + timeLabel;
        }

        private void ConfigNotSaved()
        {
            if (appStarted)
            {
                needConfigSave = true;
                lblConfigStatus.Text = "Not Saved";
                lblConfigStatus.ForeColor = Color.DarkRed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtProcName_TextChanged(object sender, EventArgs e)
        {
            Program.appConfig.ProcessName = txtProcName.Text.Trim();
            ConfigNotSaved();
        }

        private void txtKeyCode_TextChanged(object sender, EventArgs e)
        {
            Program.appConfig.KeyCode = txtKeyCode.Text.Trim();
            ConfigNotSaved();
        }

        private void nmInterval_ValueChanged_1(object sender, EventArgs e)
        {
            Program.appConfig.Interval = (int)nmInterval.Value;
            ConfigNotSaved();
        }
    }
}
