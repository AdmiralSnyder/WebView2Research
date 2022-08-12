using DockingFormBaseLibrary;
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

namespace DockChildApp
{
    public partial class Form1 : DockableForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) => DockOnProcess("TargetApp");

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("done");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
