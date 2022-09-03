using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace July5WindowsFormsApp.Model
{
    class Product
    {
        public int Number { get; set; }
        public string Date { get; set; }
        public int Inv_Num { get; set; }
        public string Obj_name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool IsAvail { get; set; }
        public bool IsNotAvail { get; set; }
        public bool OrdCom { get; set; }
        public void save()
        {
            Database d = new Database();
            d.Insert(this);
        }
        static public List<Product> GetAllProducts()
        {
            List<Product> temp = new List<Product>();
            Database d = new Database();
            temp = d.Populate();
            return temp;
        }
        public static Product findOne(string name)
        {
            List<Product> temp = new List<Product>();
            Database d = new Database();
            temp = d.Populate();
            return temp.Find(a => a.Obj_name == name);
        }
    }
}