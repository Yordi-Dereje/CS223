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
using System.Text.RegularExpressions;

namespace July5WindowsFormsApp
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            DGV.DataSource = null;
            DGV.DataSource = Product.GetAllProducts();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorPro1.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(tbNum.Text))
            {
                errorPro1.SetError(tbNum, "Number is required");
            }
            else if (string.IsNullOrEmpty(tbInvNum.Text))
            {
                errorPro1.SetError(tbInvNum, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(tbObjName.Text))
            {
                errorPro1.SetError(tbObjName, "Object name is required");
            }
            else if (string.IsNullOrEmpty(tbCount.Text))
            {
                errorPro1.SetError(tbCount, "Count is required");
            }
            else if (string.IsNullOrEmpty(tbPrice.Text))
            {
                errorPro1.SetError(tbPrice, "Price is required");
            }
            else if (!r.IsMatch(tbObjName.Text))
            {
                errorPro1.SetError(tbObjName, "String should not have numbers.");
            }
            else
            {
                try
                {
                    Product p = new Product
                    {
                        Number = int.Parse(tbNum.Text),
                        Date = dateTimePicker1.Text,
                        Inv_Num = int.Parse(tbInvNum.Text),
                        Obj_name = tbObjName.Text,
                        Count = int.Parse(tbCount.Text),
                        Price = double.Parse(tbPrice.Text),
                        IsAvail = Yes.Checked,
                        IsNotAvail = No.Checked,
                        OrdCom = IsComplete.Checked
                    };
                    p.save();
                    DGV.DataSource = null;
                    DGV.DataSource = Product.GetAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
                string message = "";
                foreach (var item in Chk_list.CheckedItems)
                {
                    message = message + item.ToString() + " ";
                }
                if (message != "")
                {
                    MessageBox.Show("User has chosen to get " + message);
                }
                tbNum.Text = "";
                tbInvNum.Text = "";
                tbObjName.Text = "";
                tbCount.Text = "";
                tbPrice.Text = "";
                Yes.Checked = false;
                No.Checked = false;
                IsComplete.Checked = false;
            }       
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
