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
            Load();
        }
        private void Load()
        {
            panel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            button1.Visible = false;
            foreach (var item in Product.GetAllProducts())
            {
                ProductCard pc = new ProductCard();
                pc.MyObjName = item.Obj_name;
                pc.MyPrice = item.Price;
                pc.Click += (Object o, EventArgs e2) =>
                {
                    panel1.Controls.Clear();
                    DetailPage d = new DetailPage(item.Number, item.Date, item.Inv_Num, item.Obj_name, item.Count, item.Price, item.IsAvail, item.OrdCom) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    panel1.Controls.Add(d);
                    d.Show();
                    button1.Visible = true;
                };
                flowLayoutPanel1.Controls.Add(pc);
                panel1.Controls.Add(flowLayoutPanel1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
