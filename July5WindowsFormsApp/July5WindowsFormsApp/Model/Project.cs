using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace July5WindowsFormsApp.Model
{
    class Project
    {
        static private List<Project> l = new List<Project>();
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
            l.Add(this);
        }
        static public List<Project> GetAllProducts()
        {
            return l;
        }
    }
}
