
namespace TuyamaKeyPresser
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
            this.btControl = new System.Windows.Forms.Button();
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.lblProcName = new System.Windows.Forms.Label();
            this.lblKeyCode = new System.Windows.Forms.Label();
            this.txtKeyCode = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInterval = new System.Windows.Forms.Label();
            this.nmInterval = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalPreview = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConfigStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btControl
            // 
            this.btControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControl.Location = new System.Drawing.Point(12, 157);
            this.btControl.Name = "btControl";
            this.btControl.Size = new System.Drawing.Size(229, 47);
            this.btControl.TabIndex = 0;
            this.btControl.Text = "Start";
            this.btControl.UseVisualStyleBackColor = true;
            this.btControl.Click += new System.EventHandler(this.btControl_Click);
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 3600000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // txtProcName
            // 
            this.txtProcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcName.Location = new System.Drawing.Point(12, 32);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(229, 26);
            this.txtProcName.TabIndex = 1;
            this.txtProcName.TextChanged += new System.EventHandler(this.txtProcName_TextChanged);
            // 
            // lblProcName
            // 
            this.lblProcName.AutoSize = true;
            this.lblProcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcName.Location = new System.Drawing.Point(8, 9);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(114, 20);
            this.lblProcName.TabIndex = 2;
            this.lblProcName.Text = "Process name:";
            // 
            // lblKeyCode
            // 
            this.lblKeyCode.AutoSize = true;
            this.lblKeyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyCode.Location = new System.Drawing.Point(160, 70);
            this.lblKeyCode.Name = "lblKeyCode";
            this.lblKeyCode.Size = new System.Drawing.Size(81, 20);
            this.lblKeyCode.TabIndex = 4;
            this.lblKeyCode.Text = "Key Code:";
            // 
            // txtKeyCode
            // 
            this.txtKeyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyCode.Location = new System.Drawing.Point(164, 93);
            this.txtKeyCode.Name = "txtKeyCode";
            this.txtKeyCode.Size = new System.Drawing.Size(77, 26);
            this.txtKeyCode.TabIndex = 3;
            this.txtKeyCode.TextChanged += new System.EventHandler(this.txtKeyCode_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTimerStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblConfigStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // lblTimerStatus
            // 
            this.lblTimerStatus.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblTimerStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTimerStatus.Name = "lblTimerStatus";
            this.lblTimerStatus.Size = new System.Drawing.Size(51, 17);
            this.lblTimerStatus.Text = "Inactive";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(8, 70);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(139, 20);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval (seconds):";
            // 
            // nmInterval
            // 
            this.nmInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmInterval.Location = new System.Drawing.Point(12, 93);
            this.nmInterval.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.nmInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmInterval.Name = "nmInterval";
            this.nmInterval.Size = new System.Drawing.Size(135, 26);
            this.nmInterval.TabIndex = 8;
            this.nmInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmInterval.Value = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.nmInterval.ValueChanged += new System.EventHandler(this.nmInterval_ValueChanged_1);
            // 
            // lblIntervalPreview
            // 
            this.lblIntervalPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalPreview.Location = new System.Drawing.Point(12, 122);
            this.lblIntervalPreview.Name = "lblIntervalPreview";
            this.lblIntervalPreview.Size = new System.Drawing.Size(229, 20);
            this.lblIntervalPreview.TabIndex = 9;
            this.lblIntervalPreview.Text = "= 2h";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.ForeColor = System.Drawing.Color.Gray;
            this.lblCopy.Location = new System.Drawing.Point(9, 218);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(185, 13);
            this.lblCopy.TabIndex = 10;
            this.lblCopy.Text = "Copyright ©2021 Tuyama Corporation";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel3.Text = "Config:";
            // 
            // lblConfigStatus
            // 
            this.lblConfigStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblConfigStatus.Name = "lblConfigStatus";
            this.lblConfigStatus.Size = new System.Drawing.Size(45, 17);
            this.lblConfigStatus.Text = "Default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 265);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.lblIntervalPreview);
            this.Controls.Add(this.nmInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblKeyCode);
            this.Controls.Add(this.txtKeyCode);
            this.Controls.Add(this.lblProcName);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.btControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuyama\'s KeyPresser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btControl;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.Label lblProcName;
        private System.Windows.Forms.Label lblKeyCode;
        private System.Windows.Forms.TextBox txtKeyCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimerStatus;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown nmInterval;
        private System.Windows.Forms.Label lblIntervalPreview;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblConfigStatus;
    }
}

