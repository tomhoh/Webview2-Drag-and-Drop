using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webview_Drag_and_Drop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1Button_Click(object sender, EventArgs e)
        {
            Form FRM1 = new Form1();
            FRM1.Show();
        }

        private void Form2Button_Click(object sender, EventArgs e)
        {
            Form FRM2 = new Form2();
            FRM2.Show();
        }

       
    }
}
