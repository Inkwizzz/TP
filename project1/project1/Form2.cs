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
        string[] fileContent;
        Users u = new Users();
        //Т.к. все в отладке, то файл выбираем через диалоговое окно
        string fileName, fileString;// = @"C:\Games\555.txt";
        public Form2(Users u)
        {
            this.u = u;
            InitializeComponent();
        }
        
        //Регистрация
        private void Registration_button_Click(object sender, EventArgs e)
        {
            FormReg newform = new FormReg();
            newform.ShowDialog();
        }

        private void Authorization_button_Click(object sender, EventArgs e)
        {
            string Login = Loginbox.Text;
            string Pas = Pasbox.Text;
            //Проверяем логин и пароль
            u.set_user(Loginbox.Text);
            Close();
        }
    }
       
}
