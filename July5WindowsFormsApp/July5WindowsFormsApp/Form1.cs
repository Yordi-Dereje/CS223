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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project
            {
                Number = int.Parse(tbNum.Text),
                Date = dateTimePicker1.Text,
                Inv_Num = int.Parse(tbInvNum.Text),
                Obj_name = tbObjName.Text,
                Count = int.Parse(tbCount.Text),
                Price = double.Parse(tbPrice.Text)
            };
            p.save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            System.Environment.Exit(0);
        }
    }
}
