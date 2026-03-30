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
        public Form1()
        {
            InitializeComponent();
        }

        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        public string sql;

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            if(!File.Exists("databaze.sqlite")) {
                SQLiteConnection.CreateFile("databaze.sqlite");
                conn = new SQLiteConnection("Data Source= databaze.sqlite;version=3;");
                conn.Open();
                sql = "CREATE TABLE udalosti (id INT PRIMARY KEY, nazev STRING, interval STRING, priorita STRING, datum DATETIME)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_Pridej_Click(object sender, EventArgs e)
        {

        }

        private void btn_Upravit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

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
    }
}
