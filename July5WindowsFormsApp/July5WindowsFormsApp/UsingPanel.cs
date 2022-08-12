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
    public partial class UsingPanel : Form
    {
        public UsingPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel3.Visible = true;
            //make the rest false
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            panel4.Visible = true;
            //make the rest false
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel5.Visible = true;
            //make the rest false
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel6.Visible = true;
            //make the rest false
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            
        }
    }
}
