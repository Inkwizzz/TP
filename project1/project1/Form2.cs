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
        private string[] fileContent;
        private Users u = new Users();
        //Т.к. все в отладке, то файл выбираем через диалоговое окно
        private string fileName, fileString;// = @"C:\Games\555.txt";
        public Form2(Users u)
        {
            this.u = u;
            InitializeComponent();
        }
        //Проверка на существования пользователя
        private bool IfReg(/*String[] fileContent,*/ string username)
        {
            if (fileContent.Contains(username)) return true;
            else return false;
        }
        //Поиск пароля по логину
        private string SearchAndMatch(string login) 
        {
            return null;
        }
        //Вынес разбиение строк из файла в отдельный метод
        private void SplitString(string str)
        {
            //Я не придумал, как убрать \r\n, поэтому я сделал сплит по \r и через цикл вручную удалил \n
            fileContent = fileString.Split('\n');
            for (int i = 0; i < fileContent.Length; i++)
            {
                int len = fileContent[i].Length;
                if (fileContent[i][len - 1] == '\r')
                {
                    fileContent[i] = fileContent[i].Substring(0, len - 1);
                }

            }
        }
        //Выбор файла с логинами и паролями тоже вынес в отдельный метод
        private void PickFile()
        {
            // Здесь считывается имя и содержание из файла в строку
            using (OpenFileDialog ofd = new OpenFileDialog())
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    var fileStream = ofd.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileString = reader.ReadToEnd();
                    }
                    fileStream.Close();
                }
        }
        //Регистрация
        private void Registration_button_Click(object sender, EventArgs e)
        {
            PickFile();
            SplitString(fileString);
            if (IfReg(loginTextBox.Text))
            {
                label1.Text = "Данный пользователь уже существует";
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    //Когда будет будет второе окно для регистрации, доделаю
                }
            }
        }
        //Авторизация
        private void Authorization_button_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string pass;
            if (IfReg(loginTextBox.Text))
            {
                pass = SearchAndMatch(loginTextBox.Text);
                if (pass == passwordTextBox.Text) 
                    u.set_user(loginTextBox.Text);

            }
            //Проверяем логин и пароль
            Close();
        }

    }
}
