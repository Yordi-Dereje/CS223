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
            var pro = Project.findOne(tbSearch.Text);
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
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
                MySqlConnection con = new MySqlConnection(pathString);
                con.Open();
                string query = "update ProjectTable set Date='" + dpt.Text + "',Inventory_Number='" + tbInvNum.Text + "',Object_Name='" + tbObjName.Text + "',Count='" + tbCount.Text + "',Price='" + tbPrice.Text + "' where Number = '" + label1.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful");
                panel1.Visible = false;
                tbSearch.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
                MySqlConnection con = new MySqlConnection(pathString);
                con.Open();
                string query = "delete from ProjectTable where Number = '" + label1.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                panel1.Visible = false;
                tbSearch.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
