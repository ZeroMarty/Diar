using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Diar
{
    public partial class Form2 : Form
    {
        public int priority;
        public DateTime datum;
        public DateTime doba1;
        public DateTime doba2;
        public TimeSpan doba;
        public string udalost;
        public bool upozorneni;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "HH:mm"; //hodiny
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datum = dateTimePicker2.Value;
            doba1 = dateTimePicker1.Value;
            doba2 = dateTimePicker3.Value;
            doba = -(doba1.Subtract(doba2));
            udalost = textBox1.Text;
            priority = int.Parse(comboBox1.SelectedItem.ToString());
            if(comboBox2.SelectedIndex == 0 )
            {
                upozorneni = true;
            }
            else if(comboBox2.SelectedIndex == 1 )
            {
                upozorneni = false;
            }
            this.Close();
        }
    }
}
