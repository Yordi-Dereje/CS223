using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using July5WindowsFormsApp.Model;
using MySql.Data.MySqlClient;

namespace July5WindowsFormsApp
{
    internal class Database
    {
        string pathString = "server = localhost; database = csharpdb; uid = root; pwd = root;";
        MySqlConnection con;
        public Database()
        {
            try
            {
                con = new MySqlConnection(pathString);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            };
        }

        public void Insert(Product p)
        {
            string query = "insert into ProjectTable values('" + p.Number + "', '" + p.Date + "', " +
                                "'" + p.Inv_Num + "', '" + p.Obj_name +
                                "', '" + p.Count + "', '" + p.Price +
                                "', '" + p.IsAvail + "', '" + p.OrdCom + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            };
        }
        public void Update(string date, string inv, string obj, string count, string price,string avail, string comp, string num)
        {
            string query = "update ProjectTable " +
                    "set Date='" + date + "',Inventory_Number='" + inv
                    + "',Object_Name='" + obj + "',Count='" + count
                    + "',Price='" + price + "',Availability='" + avail
                    + "',OrderComplete='" + comp + "' where Number = '" + num + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            };
        }

        public void Delete(string num)
        {
            string query = "delete from ProjectTable where Number = '" + num + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            };
        }

        public List<Product> Populate()
        {
            List<Product> temp = new List<Product>();
            string query = "Select * from ProjectTable";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Product p = new Product();
                    p.Number = (int)sdr["Number"];
                    p.Date = (string)sdr["Date"];
                    p.Inv_Num = (int)sdr["Inventory_Number"];
                    p.Obj_name = (string)sdr["Object_Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (double)sdr["Price"];
                    p.IsAvail = Convert.ToBoolean(sdr["Availability"]);
                    p.IsNotAvail = !(Convert.ToBoolean(sdr["Availability"]));
                    p.OrdCom = Convert.ToBoolean(sdr["OrderComplete"]);
                    temp.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            };
            return temp;
        }
    }
}
