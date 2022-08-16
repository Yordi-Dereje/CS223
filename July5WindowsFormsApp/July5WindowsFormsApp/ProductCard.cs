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
        //prop tab tab for the public
        //propfull tab tab for the private

        private int _MyNum;

        public int MyNum
        {
            get { return _MyNum; }
            set { _MyNum = value; label1.Text = value.ToString(); }
        }
        private string _MyDate;

        public string MyDate
        {
            get { return _MyDate; }
            set { _MyDate = value; label2.Text = value; }
        }
        private int _MyInvNum;

        public int MyInvNum
        {
            get { return _MyInvNum; }
            set { _MyInvNum = value; label3.Text = value.ToString(); }
        }

        private string _MyObjName;

        public string MyObjName
        {
            get { return _MyObjName; }
            set { _MyObjName = value; label4.Text = value; }
        }
        private int _MyCount;

        public int MyCount
        {
            get { return _MyCount; }
            set { _MyCount = value; label5.Text = value.ToString(); }
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

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
