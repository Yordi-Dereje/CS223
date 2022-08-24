using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace July5WindowsFormsApp.Model
{
    class Project
    {
        static private List<Project> l = new List<Project>();
        static private List<Project> tempS = new List<Project>();
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
            try
            {
                string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
                MySqlConnection con = new MySqlConnection(pathString);
                con.Open();
                string query = "insert into ProjectTable values('" + this.Number + "', '" + this.Date + "', '" + this.Inv_Num + "', '" + this.Obj_name + "', '" + this.Count + "', '" + this.Price + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static public List<Project> GetAllProducts()
        {
            List<Project> temp = new List<Project>();
            try
            {
                
                string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
                MySqlConnection con = new MySqlConnection(pathString);
                con.Open();
                string query = "Select * from ProjectTable";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Project p = new Project();
                    p.Number = (int)sdr["Number"];
                    p.Date = (string)sdr["Date"];
                    p.Inv_Num = (int)sdr["Inventory_Number"];
                    p.Obj_name = (string)sdr["Object_Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (double)sdr["Price"];
                    temp.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temp;
        }
        public static Project findOne(string name)
        {
            //List<Project> temp = new List<Project>();
            try
            {
                string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
                MySqlConnection con = new MySqlConnection(pathString);
                con.Open();
                string query = "Select * from ProjectTable";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Project p = new Project();
                    p.Number = (int)sdr["Number"];
                    p.Date = (string)sdr["Date"];
                    p.Inv_Num = (int)sdr["Inventory_Number"];
                    p.Obj_name = (string)sdr["Object_Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (double)sdr["Price"];
                    tempS.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tempS.Find(tempS => tempS.Obj_name == name);
        }
        
    }
}
