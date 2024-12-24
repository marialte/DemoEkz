using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEkz.Forms
{
    public partial class polz : Form
    {
        public polz()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string url = "https://vk.com/marialte";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}

