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
        //Проверка на существования пользователя
        private bool IfReg(/*String[] fileContent,*/ string username)
        {
            if (fileContent.Contains(username)) return true;
            else return false;
        }
        private void SearchAndMatch(string login) 
        {
            
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
                }
        }
        //Регистрация
        private void button2_Click(object sender, EventArgs e)
        {
            PickFile();
            SplitString(fileString);
            if (IfReg(textBox1.Text))
            {

            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
