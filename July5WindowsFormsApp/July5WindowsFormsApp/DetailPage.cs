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
    public partial class DetailPage : Form
    {
        public DetailPage(int num, string date, int invnum, string objname, int count, double price)
        {
            InitializeComponent();
            label1.Text = "Num: " + num.ToString();
            label2.Text = "Date: " + date;
            label3.Text = "Inv num: " + invnum.ToString();
            label4.Text = "Obj name: " + objname;
            label5.Text = "Count: " + count.ToString();
            label6.Text = "Price: " + price.ToString();
        }
    }
}
