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
    public partial class ProductCard : UserControl
    { 
        private string _MyObjName;

        public string MyObjName
        {
            get { return _MyObjName; }
            set { _MyObjName = value; label1.Text = value; }
        }
        
        private double _MyPrice;

        public double MyPrice
        {
            get { return _MyPrice; }
            set { _MyPrice = value; label6.Text = value.ToString(); }
        }

        public ProductCard()
        {
            InitializeComponent();
        }
    }
}
