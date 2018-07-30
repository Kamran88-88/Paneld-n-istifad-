using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        Person person = new Person();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Ad_TextChanged(object sender, EventArgs e)
        {
            if (Ad.Text != "" && Soyad.Text != "")
            {
                Next1.Enabled = true;
                
            }
            else
            {
                Next1.Enabled = false;
            }
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //tel and mail
        {
            if (Phone.Text!=""&&Mail.Text!="")
            {
                Next2.Enabled = true;
            }
            else
            {
                Next2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) 
        {
            if (Home_adress.Text!=""&&Work_adress.Text!="")
            {
                Save.Enabled = true;
            }
            else
            {
                Save.Enabled = false;
            }

           
            
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            person.name = Ad.Text;
            person.Surname = Soyad.Text;
            person.phone = Phone.Text;
            person.mail = Mail.Text;
            person.home_adr = Home_adress.Text;
            person.work_adr = Work_adress.Text;

            people.Add(person);
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Ad: {person.name}");
            stringBuilder.AppendLine($"Soyad: {person.Surname}");
            stringBuilder.AppendLine($"Tel: {person.phone}");
            stringBuilder.AppendLine($"Mail: {person.mail}");
            stringBuilder.AppendLine($"Ev ünvanı: {person.home_adr}");
            stringBuilder.AppendLine($"İş ünvanı: {person.work_adr}");


            MessageBox.Show(stringBuilder.ToString(), "Məlumatlar");
            Ad.Clear();
            Soyad.Clear();
            Phone.Clear();
            Mail.Clear();
            Work_adress.Clear();
            Home_adress.Clear();

            panel3.Visible = false;
            panel2.Visible = false;

        }
    }

    class Person
    {
        public string name { get; set; }
        public string Surname { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string home_adr { get; set; }
        public string work_adr { get; set; }

    }
}
