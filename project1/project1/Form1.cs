using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        string FN = "";
        public Form1()
        {

            Users u = new Users();
            Form2 newform = new Form2(u);
            newform.ShowDialog();
            string us = u.get_user();
            FN = @"C:\Games\"+us+".txt";
            InitializeComponent();
            if(DateTime.Now.Month == 1/*file Month*/)
            {
            }
            else
            {
                //Сохраняем остаток
		//some code
                int money = 333;
            }
        }
        private int change_int = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Жесткое описание работы программы*");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            int sum = 0;
            string text = "";
            try
            {
                text = textBox1.Text;
                sum = Convert.ToInt32(textBox2.Text);
            }
            catch {
                a = false;
                MessageBox.Show("Вы неправильно ввели данные");

            }
            add_money(a, sum, text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = true;
            int sum = 0;
            string text = "";
            try
            {
                text = textBox1.Text;
                sum = -Convert.ToInt32(textBox2.Text);
            }
            catch {
                a = false;
                MessageBox.Show("Вы неправильно ввели данные");
            }
            add_money(a, sum, text);
        }
        private void add_money(bool a, int sum,string text)
        {
            if(a)
            {
                
            }
            else{}
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (change_int == 2)
            {
                chart1.Visible = false;
                change_int = 0;
            }
            else if (change_int == 1)
            {
                chart1.Visible = true;
                listBox1.Visible = false;
                change_int = 2;

            }
            else if (change_int == 0) {
                listBox1.Visible = true;
                change_int = 1;


            }

        }
    }
}
