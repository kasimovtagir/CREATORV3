using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREATORV3
{
    public partial class MainSettings : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public MainSettings()
        {
            InitializeComponent();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label6.Text = "Если домен определен не корректно, поменяйте его.";
            try
            {
                textBoxNetbios.Text = Domain.GetComputerDomain().ToString();
                //_Variables.OU = _Actions.ListOU(textBoxNetbios.Text);

                string[] namesOU = _Actions.ListOU(textBoxNetbios.Text).ToArray();
                Array.Sort(namesOU);
                // Заполнение ComboBox вариантами
                comboBoxListOU.Items.AddRange(namesOU);

                // Настройка автодополнения
                comboBoxListOU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxListOU.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // Создание и заполнение источника автодополнения
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                autoCompleteCollection.AddRange(namesOU);

                // Установка источника автодополнения ComboBox
                comboBoxListOU.AutoCompleteCustomSource = autoCompleteCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось определить домен.");
            }

        }

        private void buttonSaveMainSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNetbios.Text) || string.IsNullOrEmpty(comboBoxListOU.Text))
            {
                MessageBox.Show("Поля NETBIOS и OU обязательны к заполнению.");
            }
            else
            {
                _Actions.SaveSettingsV2("AdminUserName", _Variables._FIOForSendEmail = textBoxUserName.Text.Trim());
                _Actions.SaveSettingsV2("AdminEmail", _Variables._EmailForSendEmail = textBoxEmail.Text.Trim());
                _Actions.SaveSettingsV2("AdminPassword", _Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxUserPassword.Text.Trim()));
                _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetbios.Text.Trim());

                _Actions.SaveSettingsV2("OU", _Variables.OU = comboBoxListOU.Text);
                this.Close();
            }
        }

        private void textBoxNetbios_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNetbios_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxNetbios_Leave(object sender, EventArgs e)
        {
            _Variables.NetBios = textBoxNetbios.Text.Trim();
            _Actions.ListOU(_Variables.NetBios);
        }
    }
}
