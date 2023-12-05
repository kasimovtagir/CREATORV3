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
    public partial class DefPasswordForUser : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public DefPasswordForUser()
        {
            InitializeComponent();
            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonSaveDefPasswordForUser_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("DefPasswordUser", _Variables._PasswordInAD = textBoxDefPass.Text);
            _Variables.Log.Add("Произведена смена пароля по умолчанию для пользователя.");
            this.Close();

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxDefPass.UseSystemPasswordChar = false;
            }
            else textBoxDefPass.UseSystemPasswordChar = true;
        }

        private void DefPasswordForUser_Load(object sender, EventArgs e)
        {
            textBoxDefPass.Text = _Variables._PasswordInAD = _Actions.LoadSettings2("DefPasswordUser");
        }
    }
}
