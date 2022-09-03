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
            string query = "Call InsertProc(@num, @date, @inv, @obj, @count, @price, @avail, @comp);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@num", p.Number);
            cmd.Parameters.AddWithValue("@date", p.Date);
            cmd.Parameters.AddWithValue("@inv", p.Inv_Num);
            cmd.Parameters.AddWithValue("@obj", p.Obj_name);
            cmd.Parameters.AddWithValue("@count", p.Count);
            cmd.Parameters.AddWithValue("@price", p.Price);
            cmd.Parameters.AddWithValue("@avail", MySqlDbType.Bit).Value = p.IsAvail;
            cmd.Parameters.AddWithValue("@comp", MySqlDbType.Bit).Value = p.OrdCom;
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
        public void Update(string date, string inv, string obj, string count, string price,bool avail, bool comp, string num)
        {
            string query = "call updateProc(@date, @inv, @obj, @count, @price, @avail, @comp, @num);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@inv", inv);
            cmd.Parameters.AddWithValue("@obj", obj);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@avail", MySqlDbType.Bit).Value = avail;
            cmd.Parameters.AddWithValue("@comp", MySqlDbType.Bit).Value = comp;
            cmd.Parameters.AddWithValue("@num", num);
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
            string query = "call deleteProc(@num)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@num", num);
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
