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

namespace CREATORV3
{
    public partial class FormCreateUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public FormCreateUser()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
            MainSettings newMainSett = new MainSettings();
            newMainSett._Variables = _Variables;
            newMainSett._Actions = _Actions;

            if (!File.Exists("Settings.txt"))
            {
                MessageBox.Show("У вас нет конфигурационного файла, сейчас откроется окно в котором необходимо заполнить все поля для корректной работы программы! Спасибо");
                
                using (FileStream fs = File.Create("Settings.txt"))
                {
                    //File.Create
                }
                newMainSett.ShowDialog();
            }
            else
            {
                using (StreamReader reader = new StreamReader("Settings.txt"))
                {
                    string settings = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(settings))
                    {
                        newMainSett.ShowDialog();
                    }
                    else _Actions.UploadAllSettings();
                }
            }
        }

        private void buttonCreateUserAccount_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            //метод для тестирования 
            ForTest();
        }

        public void ForTest()
        {
            textBoxNameInAD.Text = "NameForAD";
            textBoxLastNameInAD.Text = "LastNameForAD";
            textBoxLastName.Text = "LastNameRUS";
            textBoxName.Text = "NameRUS";
            textBoxThirdName.Text = "thirNameRUS";
            textBoxISUID.Text = "ISUID";
            textBoxDescription.Text = "тестовый пользователь";
            textBoxEmail.Text = "tagir.kasimov@metalab.ifmo.ru";
            textBoxPasswordUser.Text = _Variables._PasswordInAD;
            comboBoxTypePost.Text = "Сотрудник";
        }

        private void аккаунтДляОтправкиEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            accountSettings._Variables = _Variables;
            accountSettings._Actions = _Actions;
            accountSettings.ShowDialog();
        }

        private void доменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DomainSettings domainSettings = new DomainSettings();
            domainSettings._Variables = _Variables;
            domainSettings._Actions = _Actions;
            domainSettings.ShowDialog();
            showLog();
        }

        public void showLog()
        {
            listBoxLog.Items.Clear();
            foreach (var item in _Variables.Log)
            {
                listBoxLog.Items.Add(item);
            }
        }

        private void парольПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefPasswordForUser defPasswordForUser = new DefPasswordForUser();
            defPasswordForUser._Variables = _Variables;
            defPasswordForUser._Actions = _Actions;
            defPasswordForUser.ShowDialog();
            showLog();
        }

        private void текстПисьмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMessage textMessage = new TextMessage();
            textMessage._Variables = _Variables;
            textMessage._Actions = _Actions;
            textMessage.ShowDialog();
        }

        private void группыПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListGroup listGroup = new ListGroup();
            listGroup._Variables = _Variables;
            listGroup._Actions = _Actions;

            listGroup.ShowDialog();
        }
    }
}
