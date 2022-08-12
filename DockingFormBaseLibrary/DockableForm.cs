using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockingFormBaseLibrary
{
    public partial class DockableForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public static int GWL_STYLE = -16;
        public static int WS_CHILD = 0x40000000;

        public DockableForm()
        {
            InitializeComponent();
        }

        public void DockOnProcess(string processName)
        {
            Process hostProcess = Process.GetProcessesByName(processName).FirstOrDefault();
            if (hostProcess != null)
            {
                Hide();

                IntPtr hostHandle = hostProcess.MainWindowHandle;
                DockOnHandle(hostHandle);
            }
        }

        public void DockOnHandle(IntPtr hostHandle)
        {
            FormBorderStyle = FormBorderStyle.None;
            IntPtr guestHandle = this.Handle;
            SetWindowLong(guestHandle, GWL_STYLE, GetWindowLong(guestHandle, GWL_STYLE) | WS_CHILD);
            SetParent(guestHandle, hostHandle);

            Dock = DockStyle.Fill;
            Show();
        }
    }
}
