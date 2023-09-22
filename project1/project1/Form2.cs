using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form2 : Form
    {
        Users u;
        //Путь к файлу
        string FN = "";
        public Form2(Users u)
        {
            this.u = u;
            InitializeComponent();
        }


        //Авторизация
        private void Authorization_button_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Pas = textBox2.Text;
            //Проверяем логин и пароль
            u.set_user(textBox1.Text);
            Close();
        }

        //Регистрация
        private void Registration_button_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Pas = textBox2.Text;
        }
    }
}
