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
        private void btn_StartCleaning_Click(object sender, EventArgs e)
        {
            lbl_StatusMsg.Text = "Cleaning...";
            Cleaner cleaner = new Cleaner();
            cleaner.StartCleaning();
            lbl_StatusMsg.Text = "Finished Cleaning";
        }
    }
}
