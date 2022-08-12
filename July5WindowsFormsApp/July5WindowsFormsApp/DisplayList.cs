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
    public partial class DisplayList : Form
    {
        public DisplayList()
        {
            InitializeComponent();
        }

        private void DisplayList_Load(object sender, EventArgs e)
        {
            
            foreach(var item in Project.GetAllProducts())
            {
                ProductCard pc = new ProductCard();
                pc.MyNum = item.Number;
                pc.MyDate = item.Date;
                pc.MyInvNum = item.Inv_Num;
                pc.MyObjName = item.Obj_name;
                pc.MyCount = item.Count;
                pc.MyPrice = item.Price;
                flowLayoutPanel1.Controls.Add(pc);
            }
        }
    }
}
