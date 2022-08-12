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
using System.Xml.Linq;

namespace TargetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exeName = $"WebView2Projectx{(Environment.Is64BitProcess ? "64" : "86")}";  
            remoteAppUserControl1.ProcessPath = $@"..\..\..\{exeName}\bin\debug\{exeName}.exe";
            //IntPtr hwnd = this.Handle;
            remoteAppUserControl1.Init();
            //Process.Start(@"..\..\..\DockChildApp\bin\debug\DockChildApp.exe", hwnd.ToString());
        }
    }
}
