using July5WindowsFormsApp.Model;
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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var pro = Project.findOne(tbSearch.Text);
            if (pro == null)
            {
                MessageBox.Show("Not Found!");
            }
            else
            {
                //Project.findOne(pro.Obj_name);
                MessageBox.Show("Found");
            }
        }
    }
}
