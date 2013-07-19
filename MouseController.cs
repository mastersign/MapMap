using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MapMap
{
    static class MouseController
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void MouseDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN,
                (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        public static void MouseUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP,
                (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        public static void Click()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP,
                (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }
    }
}
