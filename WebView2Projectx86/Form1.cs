using DockingFormBaseLibrary;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2Projectx86
{
    public partial class Form1 : DockableForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            var webView = new WebView2() { Dock = DockStyle.Fill };
            await webView.EnsureCoreWebView2Async(await CoreWebView2Environment.CreateAsync(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebView2")));
            Controls.Add(webView);
            webView.CoreWebView2.Navigate("https://www.google.com");
        }
    }
}
