using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Generic;
using System.Data.SQLite.Linq;

namespace Kunddatabas
{
    public partial class Form1 : Form
    {

        string stm = "SELECT SQLITE_VERSION()";

        string cs = @"URI=file:C:\Users\calci\OneDrive\Dokument\Database\kundupgifter.db"; // path hosted locally



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"SQLite version: {version}");
            Console.WriteLine("Updating database");


            string[] tables = { "t_person", "t_adress", "t_distribution" };

            foreach(var table in tables)
            {
                command("DROP TABLE IF EXISTS "+table, cmd);
                
            }
            command("CREATE TABLE t_person(id INTEGER PRIMARY KEY, name TEXT)", cmd);
            command("CREATE TABLE t_adress(id INTEGER PRIMARY KEY, gatuadress TEXT, postadress INT)", cmd);
            command("CREATE TABLE t_distribution(id INTEGER PRIMARY KEY, distributionstyp TEXT)", cmd);
            //delete


            //create

            // Post, Email, Kivra, Efaktura

            //fill
            command("INSERT INTO t_person(name) VALUES('Johan Nilsson')", cmd);
                command("INSERT INTO t_adress(gatuadress, postadress) VALUES('1019 Oak Lane', '65330')", cmd);
                command("INSERT INTO t_distribution(distributionstyp) VALUES('Kivra')", cmd);

            command("INSERT INTO t_person(name) VALUES('Georg Gunnar')", cmd);
                command("INSERT INTO t_adress(gatuadress, postadress) VALUES('4665 Marshall Street', '20707')", cmd);
                command("INSERT INTO t_distribution(distributionstyp) VALUES('Email')", cmd);

            command("INSERT INTO t_person(name) VALUES('Buse Burre')", cmd);
                command("INSERT INTO t_adress(gatuadress, postadress) VALUES('2071 Franklin Avenue', '78380')", cmd);
                command("INSERT INTO t_distribution(distributionstyp) VALUES('Efaktura')", cmd);

            command("INSERT INTO t_person(name) VALUES('Vilson Kycklin')", cmd);
                command("INSERT INTO t_adress(gatuadress, postadress) VALUES('98 Whaley Lane', '78380')", cmd);
                command("INSERT INTO t_distribution(distributionstyp) VALUES('Post')", cmd);

            command("INSERT INTO t_person(name) VALUES('Koppe Ragnarok')", cmd);
                command("INSERT INTO t_adress(gatuadress, postadress) VALUES('921 Gandy Street', '13202')", cmd);
                command("INSERT INTO t_distribution(distributionstyp) VALUES('Kivra')", cmd);
            

            Console.WriteLine("Johan och Gunnar ska taxi.");


            //list
            string search = "SELECT * FROM t_person LIMIT 5";

            var cmd2 = new SQLiteCommand(search, con);

            SQLiteDataReader rdr = cmd2.ExecuteReader();




            while (rdr.Read())
            {

                Console.WriteLine($" {rdr.GetInt32(0), -7} {rdr.GetString(1)}");
            }
            rdr.Close();

            
        }
        private void command(string command, SQLiteCommand sqlcmd)
        {
            sqlcmd.CommandText = command;
            sqlcmd.ExecuteNonQuery();
        }



        private List<string> getInfo(int id)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            


            string search = "SELECT name FROM t_person WHERE id = " + id.ToString();

            List<string> results = new List<string>();
            var cmd = new SQLiteCommand(search, con);

            Console.WriteLine("Getting name. SQL : "+ search);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results.Add(rdr.GetString(0));

            } rdr.Close();

            search = "SELECT gatuadress, postadress FROM t_adress WHERE id = " + id.ToString();
            cmd = new SQLiteCommand(search, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results.Add(rdr.GetString(0));
                results.Add(rdr.GetInt32(1).ToString());

            } rdr.Close();
            search = "SELECT distributionstyp FROM t_distribution WHERE id = " + id.ToString();
            cmd = new SQLiteCommand(search, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results.Add(rdr.GetString(0));

            }
            rdr.Close();


            //string result = "";

            //foreach(var res in results)
            //{
            //    result = resul
            //}

            return results;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // search
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);

            bert.Controls.Clear();
            bert.Controls.Add(new Label() { Text = "Namn" }, 0, 0);
            bert.Controls.Add(new Label() { Text = "Gatuadress" }, 1, 0);
            bert.Controls.Add(new Label() { Text = "Postadress" }, 2, 0);
            bert.Controls.Add(new Label() { Text = "Distributionstyp" }, 3, 0);


            string search = "SELECT id FROM t_person WHERE name LIKE '%" + textBox1.Text + "%'";

            var searchway = comboBox1.Text;

            if (searchway=="Namn")
            {
                search = "SELECT id FROM t_person WHERE name LIKE '%" + textBox1.Text + "%'";
            } else if(searchway=="Gatuadress")
            {
                search = "SELECT id FROM t_adress WHERE gatuadress LIKE '%" + textBox1.Text + "%'";
            }
            else if (searchway == "Postadress")
            {
                search = "SELECT id FROM t_adress WHERE postadress LIKE '%" + textBox1.Text + "%'";
            }
            else if (searchway == "Distributionstyp")
            {
                search = "SELECT id FROM t_distribution WHERE distributionstyp LIKE '%" + textBox1.Text + "%'";
            }
            cmd = new SQLiteCommand(search, con);
            SQLiteDataReader idrdr = cmd.ExecuteReader();
                

            while (idrdr.Read())
            {
                int id = idrdr.GetInt32(0);

                string info = "";

                foreach(var inf in getInfo(id))
                {
                    info = info + inf.ToString();

                    Console.WriteLine(inf);
                    bert.Controls.Add(new Label() { Text = inf });
                        
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);


            string name = namn.Text;
            string gata = gatuadress.Text;
            string post = postadress.Text;
            string dist = distributionstyp.Text;


            if(name==String.Empty || gata==String.Empty || post==String.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Du bör fylla i alla rutor!");
                return;
            }

            command("INSERT INTO t_person(name) VALUES('"+name+"')", cmd);
            command("INSERT INTO t_adress(gatuadress, postadress) VALUES('"+gata+"', '"+post+"')", cmd);
            command("INSERT INTO t_distribution(distributionstyp) VALUES('"+dist+"')", cmd);

            System.Windows.Forms.MessageBox.Show(namn+" registerad!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabort_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);


            string id = textBox2.Text;
            command("DELETE FROM t_person WHERE id = " + id.ToString(), cmd);
            command("DELETE FROM t_adress WHERE id = " + id.ToString(), cmd);
            command("DELETE FROM t_distribution WHERE id = " + id.ToString(), cmd);

            System.Windows.Forms.MessageBox.Show("Borttagningen lyckades!");
        }
    }
}
