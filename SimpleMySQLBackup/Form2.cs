using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleMySQLBackup
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/AMuhaimin/SimpleMysql");
        }
    }
}
