using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREATORV3
{
    public partial class TextMessage : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public TextMessage()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonSaveTextMessage_Click(object sender, EventArgs e)
        {
            if (checkBoxRussianText.Checked)
            {
                _Variables.SubjectTextMessageForSendEmail_RUS = textBoxSubject.Text;
                _Variables.TextMessageForSendEMAIL_RUS = textBoxText.Text;
                _Actions.SavingTextForSendEmail("RUS");
            }
            else
            {
                _Variables.SubjectTextMessageForSendEmail_ENG = textBoxSubject.Text;
                _Variables.TextMessageForSendEMAIL_ENG = textBoxText.Text;
                _Actions.SavingTextForSendEmail("ENG");
            }
        }

        private void TextMessage_Load(object sender, EventArgs e)
        {
            _Actions.LoadText("RUS");
            textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
            textBoxText.Text = _Variables.TextMessageForSendEMAIL_RUS;

            label3.ForeColor = Color.Red;
            label3.Text = "*В текста ОБЯЗАТЕЛЬНО должны быть следующие переменные: \nADName - вместо этого текста будет вставлен логин пользователя \nADPassword - вместо этого текста будет написан пароль пользователя.";
        }

        private void checkBoxRussianText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRussianText.Checked)
            {
                checkBoxEnglishText.Checked = false;
                label1.Text = "Тема письма";
                label2.Text = "Текст письма";

                _Actions.LoadText("RUS");

                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_RUS;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_RUS;
            }
        }

        private void checkBoxEnglishText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnglishText.Checked)
            {
                checkBoxRussianText.Checked = false;
                label1.Text = "Subject";
                label2.Text = "Text message";

                _Actions.LoadText("ENG");

                textBoxSubject.Text = _Variables.SubjectTextMessageForSendEmail_ENG;
                textBoxText.Text = _Variables.TextMessageForSendEMAIL_ENG;
            }
        }
    }
}
