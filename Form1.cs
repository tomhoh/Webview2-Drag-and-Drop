using Microsoft.Web.WebView2.WinForms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Webview_Drag_and_Drop
{
	public partial class Form1 : Form
	{

		public WebView2 wv2;

		public Form1()
		{
			InitializeComponent();
			Init();
		}

		public async void Init()
		{
			wv2 = new WebView2();
			this.Controls.Add(wv2);
			wv2.Dock = DockStyle.Fill;
			await wv2.EnsureCoreWebView2Async();

			wv2.CoreWebView2.AddHostObjectToScript("WV_File", new WV_File(this));

			string path = "file:///" + Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "index.html");
			wv2.Source = new Uri(path);
		}
	}

	[ComVisible(true)]
	public class WV_File
	{

		Form1 M;

		public WV_File(Form1 m)
		{
			this.M = m;
		}

		public void DragDropFile(string path)
		{
			Console.WriteLine("draganddrop");
            if (File.Exists(path) == false)
            {
                Console.WriteLine("file not exists");
                return;
            }
            string[] files = { path };
			try
			{
				Console.WriteLine("DragTry");
				var file = new System.Windows.Forms.DataObject(System.Windows.Forms.DataFormats.FileDrop, files);
				M.DoDragDrop(file, DragDropEffects.All);
			}
			catch { }
		}
	}
}
