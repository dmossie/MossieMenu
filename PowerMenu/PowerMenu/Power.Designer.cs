namespace PowerMenu
{
    partial class Power
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
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonHibernate = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(12, 11);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(125, 50);
            this.buttonLock.TabIndex = 0;
            this.buttonLock.Tag = "0";
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(12, 67);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(125, 50);
            this.buttonLog.TabIndex = 1;
            this.buttonLog.Tag = "1";
            this.buttonLog.Text = "Log Out";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Location = new System.Drawing.Point(143, 11);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(125, 50);
            this.buttonSleep.TabIndex = 2;
            this.buttonSleep.Tag = "2";
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonHibernate
            // 
            this.buttonHibernate.Location = new System.Drawing.Point(143, 67);
            this.buttonHibernate.Name = "buttonHibernate";
            this.buttonHibernate.Size = new System.Drawing.Size(125, 50);
            this.buttonHibernate.TabIndex = 3;
            this.buttonHibernate.Tag = "3";
            this.buttonHibernate.Text = "Hibernate";
            this.buttonHibernate.UseVisualStyleBackColor = true;
            this.buttonHibernate.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(272, 11);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(125, 50);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Tag = "4";
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(274, 67);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(125, 50);
            this.buttonPower.TabIndex = 5;
            this.buttonPower.Tag = "5";
            this.buttonPower.Text = "Shut Down";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 129);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonHibernate);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonLock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Power";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PowerMenu_FormClosed);
            this.Load += new System.EventHandler(this.PowerMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonHibernate;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonPower;

    }
}

