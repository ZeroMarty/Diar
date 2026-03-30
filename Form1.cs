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
            public udalost (DateTime cas, Form1 main, int operace)
            {
                this.cas = cas;
                this.operace = operace;
                main.operace = operace;
                main.cas = cas;
                if(operace == 1)
                {
                    main.udalosti[main.id-1] = cas;
                }
                else if(operace == 2)
                {
                    main.udalosti.RemoveAt(main.id-1);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            if(!File.Exists("databaze.sqlite")) {
                SQLiteConnection.CreateFile("databaze.sqlite");
                conn = new SQLiteConnection("Data Source= databaze.sqlite;version=3;");
                conn.Open();
                sql = "CREATE TABLE udalosti (id INT PRIMARY KEY, nazev varchar, interval varchar, priorita varchar, datum varchar)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_Pridej_Click(object sender, EventArgs e)
        {
            operace = 1;
            conn.Open();
            int id = hledaniid();
            sql =$"";

            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "SELECT * FROM udalosti ORDER BY id";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_Upravit_Click(object sender, EventArgs e)
        {
            conn.Open();
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            operace = 1;
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "SELECT * FROM udalosti ORDER BY id";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            operace = 2;
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "SELECT * FROM udalosti ORDER BY id";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
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
                if (cas == udalosti[i])
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
