/*
Power Menu
Created By: Daniel Mossie
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PowerMenu
{
    public partial class Power : Form
    {
        //User32 function for selecting window
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        //LogOff/Restart/Shutdown
        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        //Lock
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();


        //Hibernate/Sleep
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        //IntPtr to form
        private IntPtr thisWindow;

        //Show/Hide hot key
        private Hotkey hotkey;

        //Menu Loaded
        private void PowerMenu_Load(object sender, EventArgs e)
        {
            thisWindow = FindWindow(null, "Power");
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
        }

        //Form Closed
        private void PowerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remove the hot key
            hotkey.UnRegisterHotKeys();
        }

        //Windows Processes
        protected override void WndProc(ref Message keyPressed)
        {
            //If a hotkey was triggered
            if (keyPressed.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)keyPressed.LParam >> 16) & 0xFFFF);
                int modifier = ((int)keyPressed.LParam & 0xFFFF);

                //Test for CTRL+W
                if (key.ToString() == "OemPeriod" && modifier == 2)
                {
                    //Minimize or maximize the form
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else if (this.Visible == true) this.Hide();
                    else this.Show();
                }
            }
            base.WndProc(ref keyPressed);
        }

        public Power()
        {
            InitializeComponent();
        }
        private void buttonAction_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;
            int tag;
            int.TryParse(button.Tag.ToString(), out tag);
            
            if (tag == 0 || tag == 2 || tag == 3) this.Hide();

            //Lock
            if (tag == 0) LockWorkStation();
            //Log Out
            else if (tag == 1) ExitWindowsEx(0, 0);
            //Sleep
            else if (tag == 2) SetSuspendState(false, true, true);
            //Hibernate
            else if (tag == 3) SetSuspendState(true, true, true);
            //Restart
            else if (tag == 4) Process.Start("shutdown", "/r /t 0");
            //Shutdown
            else if (tag == 5) Process.Start("shutdown", "/s /t 0");

            else MessageBox.Show("Error! Can not compute!");
            
        }
    }
}
