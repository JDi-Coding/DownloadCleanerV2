using DownloadCleanerV2.assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadCleanerV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] Files = Cleaner.GetFiles(@"E:\Downloads\");
            foreach (string File in Files)
            {
                textBox1.Text += File + Environment.NewLine;
            }
            string[] Folders = Cleaner.GetFolders(@"E:\Downloads\");
            foreach (string Folder in Folders)
            {
                textBox2.Text += Folder + Environment.NewLine;
            }

        }
    }
}
