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
        string FN = ""; //Путь к файлу
        Users u = new Users();
        public Form1()
        {
            //Полуаем данные из авторизации, 
            Form2 newform = new Form2(u);
            newform.ShowDialog();
            string us = u.get_user();


            //Если не был введён логин, то и второе окно сразу закрывается
            if(us == "")
            {
                Close();
            }
            FN = @"C:\Games\"+us+".txt";
            InitializeComponent();


            if(DateTime.Now.Month == 1/*file Month*/)
            {
            }
            else
            {
                //Полуаем остаток, а затем добавляем в файл
                add_money(333,"Остаток с прошлого месяца");
            }
        }
        private int change_int = 0;
        private void add_money(int sum,string text)
        {
            //Добавляем в файл
        }

        private void Decrease_money_button_Click(object sender, EventArgs e)
        {
            Money_operation(-1);
        }

        //Работа с введенными данными (Добавить или убавить)
        private void Money_operation(int Add)
        {
            int sum = 0;
            string text = "";
            try
            {
                text = textBox1.Text;
                sum = Add*Convert.ToInt32(textBox2.Text);
                add_money(sum, text);
            }
            catch
            {
                MessageBox.Show("Вы неправильно ввели данные");
            }
        }

        private void Add_money_button_Click(object sender, EventArgs e)
        {
            Money_operation(1);
        }

        //Отображение трат
        private void Display_button_Click(object sender, EventArgs e)
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
            else if (change_int == 0)
            {
                listBox1.Visible = true;
                change_int = 1;


            }
        }

        private void faq_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Жесткое описание работы программы*");
        }
    }
}