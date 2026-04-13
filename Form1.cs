using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.SQLite;

namespace Diar
{
    public partial class Form1 : Form
    {
        public class udalost
        {
            Form1 main;
            DateTime cas;
            int operace;
            bool upozorneni;
            string name;
            public udalost (DateTime cas, Form1 main, int operace, bool upozorneni, string name)
            {
                this.cas = cas;
                this.operace = operace;
                this.upozorneni = upozorneni;
                this.name = name;
                main.upozorneni=upozorneni;
                main.operace = operace;
                main.cas = cas;
                main.nazev = name;
                if(operace == 1)
                {
                    main.udalosti.Add(cas);
                    main.alarm.Add(upozorneni);
                    main.nazvy.Add(name);
                }
                else if(operace == 2)
                {
                    main.alarm[main.id - 1] = upozorneni;
                    main.udalosti[main.id - 1] = cas;
                    main.nazvy[main.id - 1] = name;

                }
                else if(operace == 3)
                {
                    main.udalosti.RemoveAt(main.id-1);
                    main.alarm.RemoveAt(main.id - 1);
                    main.nazvy.RemoveAt(main.id - 1);
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        public string sql;
        public int operace; //1 přidá/upraví, 2 odebere
        public int id;
        public DateTime cas;
        public List<DateTime> udalosti;
        public string nazev;
        public List<bool> alarm;
        public bool upozorneni;
        public List<string> nazvy;
        public string ctverec;
        private void Form1_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            if(!File.Exists("databaze.sqlite")) {
                SQLiteConnection.CreateFile("databaze.sqlite");
                conn = new SQLiteConnection("Data Source= databaze.sqlite;version=3;");
                conn.Open();
                sql = "CREATE TABLE udalosti (id INT PRIMARY KEY, nazev varchar, interval TimeSpan, dulezitost varchar, datum DateTime, alarm bool)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn = new SQLiteConnection("Data Source= databaze.sqlite;version=3;");
            }
        }

        private void btn_Pridej_Click(object sender, EventArgs e)
        {
            using (var dialog = new Form2())
            {
                dialog.ShowDialog();
                int priorita = dialog.priority;
                cas = dialog.datum;
                TimeSpan doba = dialog.doba;
                upozorneni = dialog.upozorneni;
                nazev = dialog.udalost;
                if(priorita == 1)
                {
                    ctverec = "\u001b[31m█\u001b[0m"; //pro referenci: https://gist.github.com/dominikwilkowski/60eed2ea722183769d586c76f22098dd
                }
                else if(priorita == 2)
                {
                    ctverec = "\u001b[33m█\u001b[0m";
                }
                else if(priorita == 3)
                {
                    ctverec = "\u001b[32m█\u001b[0m";
                }
                operace = 1;
                udalost udal = new udalost (cas, this, operace, upozorneni, nazev);
                conn.Open();
                id = hledaniid();
                sql = $"INSERT INTO udalosti(id, nazev, interval, dulezitost, datum, alarm) VALUES({id}, {nazev}, {doba},{ctverec},{cas},{upozorneni} )";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "SELECT * FROM udalosti ORDER BY id";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
        }
        private void btn_Upravit_Click(object sender, EventArgs e)
        {
            using (var dialog = new Form2())
            {
                conn.Open();
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                operace = 2;
                sql = "SELECT * FROM udalosti ORDER BY id";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (var dialog = new Form2())
            {
                conn.Open();
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                operace = 3;
                sql = "SELECT * FROM udalosti ORDER BY id";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private int hledaniid()
        {
            conn.Open();
            sql = "SELECT * FROM udalosti ORDER BY id";
            cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            int hledani = 1;
            while (reader.Read())
            {
                int idted = reader.GetInt32(0);
                if (hledani != idted)
                {
                    reader.Close();
                    conn.Close();
                    return hledani;
                }
                hledani++;
            }
            reader.Close();
            conn.Close();
            return hledani;
        }

        private void kontrola()
        {
            Application.DoEvents();
            DateTime cas = DateTime.Now;
            for (int i = 0; i < udalosti.Count; i++)
            {
                if (cas == udalosti[i] && upozorneni == alarm[i])
                {
                    MessageBox.Show("Upozornění:" + nazev);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            kontrola();
        }
    }
}
