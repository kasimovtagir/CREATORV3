using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace CREATORV3
{
    public class Variables
    {
        // настройки учетной записи для отправки писем на электронную почту
        private string FIOForSendEMail;
        public string _FIOForSendEmail
        {
            get { return FIOForSendEMail; }
            set { FIOForSendEMail = value; }
        }

        private string EmailForSendEMail;
        public string _EmailForSendEmail
        {
            get { return EmailForSendEMail; }
            set { EmailForSendEMail = value; }
        }

        private string PasswordForSendEmail;
        public string _PasswordForSendEmail
        {
            get { return PasswordForSendEmail; }
            set { PasswordForSendEmail = value; }
        }

        //поля для текста который будет отправлен пользователю 
        public string SubjectTextMessageForSendEmail_RUS { get; set; }
        public string TextMessageForSendEMAIL_RUS { get; set; }

        public string SubjectTextMessageForSendEmail_ENG { get; set; }
        public string TextMessageForSendEMAIL_ENG { get; set; }

        //переменные для списка групп в которые будет добавлен новый пользователь 
        private List<string> ListGroupForAddEmployeer = new List<string>();
        public List<string> _ListGroupForAddEmployeer
        {
            get { return ListGroupForAddEmployeer; }
            set { ListGroupForAddEmployeer = value; }
        }

        private List<string> ListGroupForAddStudent = new List<string>();
        public List<string> _ListGroupForAddStudent
        {
            get { return ListGroupForAddStudent; }
            set { ListGroupForAddStudent = value; }
        }

        private List<string> ListGroupForAddSUZsPF = new List<string>();
        public List<string> _ListGroupForAddSUZsPF
        {
            get { return ListGroupForAddSUZsPF; }
            set { ListGroupForAddSUZsPF = value; }
        }

        //Список всех групп
        public List<string> ListAllGroups = new List<string>();


        // поле для переменной netbios
        public string NetBios { get; set; }
        public string splitNetBios;
        public string OU;
        public List<string> _ListOU;

        //паля для подключения к АД
        public PrincipalContext principalContext;
        public GroupPrincipal group { get; set; }



        //паля для заполнения информации об новом сотруднике
        public string _nameInAD;
        public string _lastNameInAD;
        public string _SamAccountInAD;
        public string _PasswordInAD;

        public string _UserlastName;
        public string _UserName;
        public string _UserThistName;
        public string _UserISU_ID;
        public string _UserDescription;
        public string _UsersEmail;
        public string _TypePost;

        public bool _WithEmail;


        public List<string> Log = new List<string>();

        // Список всех пользователей в AD
        private List<string> listAllUsers = new List<string>();
        public List<string> AllUsersInAD //{ get; set; }
        {
            get { return listAllUsers; }
            set { listAllUsers = value; }
        }
    }
}
