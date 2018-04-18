namespace NewMenu
{
    partial class NewMenu
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
            this.panelLaunch = new System.Windows.Forms.Panel();
            this.panelLaunchList = new System.Windows.Forms.Panel();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.panelLaunchControls = new System.Windows.Forms.Panel();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelLaunch.SuspendLayout();
            this.panelLaunchList.SuspendLayout();
            this.panelLaunchControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLaunch
            // 
            this.panelLaunch.Controls.Add(this.panelLaunchList);
            this.panelLaunch.Controls.Add(this.panelLaunchControls);
            this.panelLaunch.Location = new System.Drawing.Point(0, 0);
            this.panelLaunch.Name = "panelLaunch";
            this.panelLaunch.Size = new System.Drawing.Size(584, 361);
            this.panelLaunch.TabIndex = 0;
            // 
            // panelLaunchList
            // 
            this.panelLaunchList.Controls.Add(this.listBoxPaths);
            this.panelLaunchList.Location = new System.Drawing.Point(170, 0);
            this.panelLaunchList.Name = "panelLaunchList";
            this.panelLaunchList.Size = new System.Drawing.Size(414, 361);
            this.panelLaunchList.TabIndex = 1;
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPaths.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.ItemHeight = 24;
            this.listBoxPaths.Location = new System.Drawing.Point(0, 0);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(414, 364);
            this.listBoxPaths.TabIndex = 0;
            this.listBoxPaths.TabStop = false;
            this.listBoxPaths.DoubleClick += new System.EventHandler(this.listBoxPaths_DoubleClick);
            this.listBoxPaths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxPaths_KeyPress);
            // 
            // panelLaunchControls
            // 
            this.panelLaunchControls.Controls.Add(this.buttonRename);
            this.panelLaunchControls.Controls.Add(this.buttonDown);
            this.panelLaunchControls.Controls.Add(this.buttonUp);
            this.panelLaunchControls.Controls.Add(this.buttonRemove);
            this.panelLaunchControls.Controls.Add(this.buttonAdd);
            this.panelLaunchControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLaunchControls.Location = new System.Drawing.Point(0, 0);
            this.panelLaunchControls.Name = "panelLaunchControls";
            this.panelLaunchControls.Size = new System.Drawing.Size(164, 361);
            this.panelLaunchControls.TabIndex = 0;
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(26, 122);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(110, 40);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.TabStop = false;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(26, 309);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(110, 40);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(26, 263);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(110, 40);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(26, 76);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 40);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.TabStop = false;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(26, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // NewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMenu_FormClosed);
            this.Load += new System.EventHandler(this.NewMenu_Load);
            this.panelLaunch.ResumeLayout(false);
            this.panelLaunchList.ResumeLayout(false);
            this.panelLaunchControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaunch;
        private System.Windows.Forms.Panel panelLaunchControls;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Panel panelLaunchList;
        private System.Windows.Forms.ListBox listBoxPaths;
    }
}

