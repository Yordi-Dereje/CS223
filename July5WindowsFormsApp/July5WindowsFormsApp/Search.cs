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
using MySql.Data.MySqlClient;

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
            var pro = Product.findOne(tbSearch.Text);
            if (pro == null)
            {
                if(panel1.Visible == true)
                {
                    panel1.Visible = false;
                }    
                MessageBox.Show("Not Found!");
            }
            else
            {
                panel1.Visible = true;
                label1.Text = pro.Number.ToString();
                dpt.Text = pro.Date.ToString();
                tbInvNum.Text = pro.Inv_Num.ToString();
                tbObjName.Text = pro.Obj_name;
                tbCount.Text = pro.Count.ToString();
                tbPrice.Text = pro.Price.ToString();
                tbAvail.Text = pro.IsAvail.ToString();
                tbComp.Text = pro.OrdCom.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            d.Update(dpt.Text, tbInvNum.Text, tbObjName.Text, tbCount.Text, tbPrice.Text, tbAvail.Text, tbComp.Text, label1.Text);
            panel1.Visible = false;
            tbSearch.Text = "";
        }  
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            d.Delete(label1.Text);
            panel1.Visible = false;
            tbSearch.Text = "";
        }
    }
}
