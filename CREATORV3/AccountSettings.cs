using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CREATORV3
{
    public partial class AccountSettings : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public AccountSettings()
        {
            InitializeComponent();
            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("AdminUserName", _Variables._FIOForSendEmail = textBoxNameLastName.Text.Trim());
            _Actions.SaveSettingsV2("AdminEmail", _Variables._EmailForSendEmail = textBoxEmail.Text.Trim());
            _Actions.SaveSettingsV2("AdminPassword", _Variables._PasswordForSendEmail = _Actions.Encrypt(textBoxPassword.Text.Trim()));

            this.Close();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            //выгрузить данный из файла 
            textBoxNameLastName.Text = _Variables._FIOForSendEmail = _Actions.LoadSettings2("AdminUserName");
            textBoxEmail.Text = _Variables._EmailForSendEmail = _Actions.LoadSettings2("AdminEmail");
            textBoxPassword.Text = _Actions.Decrypt(_Variables._PasswordForSendEmail = _Actions.LoadSettings2("AdminPassword"));
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
