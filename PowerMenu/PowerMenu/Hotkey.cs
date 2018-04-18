using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PowerMenu
{
    class Hotkey
    {
        //Hex values for buttons
        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008,
        }

        private IntPtr _hWnd;

        //Hotkey set up and take down
        public Hotkey(IntPtr hWnd)
        {
            this._hWnd = hWnd;
        }

        public void RegisterHotKeys()
        {
            RegisterHotKey(_hWnd, 1, (uint)fsModifiers.Control, (uint)Keys.OemPeriod);
        }

        public void UnRegisterHotKeys()
        {
            UnregisterHotKey(_hWnd, 1);
        }

        //User32.dll Functions for registering/unregistering hot keys
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    }
}
