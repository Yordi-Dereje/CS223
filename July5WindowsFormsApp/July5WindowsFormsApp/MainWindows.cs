using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace July5WindowsFormsApp
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Input f = new Input();
            f.MdiParent = this;
            f.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Search s = new Search();
            s.MdiParent = this;
            s.Show();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            DisplayList dl = new DisplayList();
            dl.MdiParent = this;
            dl.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
