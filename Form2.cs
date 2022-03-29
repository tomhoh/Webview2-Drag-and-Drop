using Microsoft.Web.WebView2.WinForms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Webview_Drag_and_Drop
{
	public partial class Form2 : Form
	{

		public WebView2 wv3;

		public Form2()
		{
			InitializeComponent();
			Init();
		}
		public async void Init()
		{
			wv3 = new WebView2();
			this.Controls.Add(wv3);
			wv3.Dock = DockStyle.Fill;
			await wv3.EnsureCoreWebView2Async();

			string path = "file:///" + Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "page1.html");
			wv3.Source = new Uri(path);

			wv3.CoreWebView2.NewWindowRequested += (sender2, e2) => {
				String _fileurl = e2.Uri.ToString();
				e2.Handled = true;
				RunJs($"var temp_dropPath = \"{_fileurl}\"");
			};
		}

		public void RunJs(String js)
		{
			if (wv3.CoreWebView2 != null)
				wv3.CoreWebView2.ExecuteScriptAsync(js);
		}
	}

}
