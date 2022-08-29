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
        public DetailPage(int num, string date, int invnum, string objname, int count, double price, bool avail, bool comp)
        {
            InitializeComponent();
            label9.Text = num.ToString();
            label10.Text = date;
            label11.Text = invnum.ToString();
            label12.Text = objname;
            label13.Text = count.ToString();
            label14.Text = price.ToString();
            label15.Text = avail.ToString();
            label16.Text = comp.ToString();
        }
    }
}
