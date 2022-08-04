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
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Search s = new Search();
            s.MdiParent = this;
            s.Show();
        }

        
    }
}
