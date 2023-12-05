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
    public partial class ListGroup : Form
    {
        public Variables _Variables;
        public Actions _Actions;
        public ListGroup()
        {
            InitializeComponent();
            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveList(listBoxListGroupForEmployees, "ListGroupForEmplyees", _Variables._ListGroupForAddEmployeer);
            SaveList(listBoxListGroupForStudent, "ListGroupForStudent", _Variables._ListGroupForAddStudent);
            this.Close();
        }

        /// <summary>
        /// метод для сохранения списка из listbox'а в файл 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="IndexLine"></param>
        /// <param name="listGroups"></param>
        public void SaveList(ListBox listBox, string IndexLine, List<string> listGroups)
        {
            string list = string.Empty;
            foreach (string item in listBox.Items)
            {
                listGroups.Add(item);
                list += item + ";";
            }
            _Actions.SaveSettingsV2(IndexLine, list);
            //_Actions.SaveSetting(list, IndexLine);
        }

        /// <summary>
        /// группа для выгрузки списка групп из файла с настройками 
        /// </summary>
        /// <param name="listGroup"></param>
        /// <param name="listBoxGroup"></param>
        /// <param name="indexLine"></param>
        public void uploadListGroup(List<string> listGroup, ListBox listBoxGroup, string whatneed)
        {
            //выгрузка списка групп для сотрудника
            //string[] listGroups = _Actions.LoadSetting(indexLine).Split(";");
            string[] listGroups = _Actions.LoadSettings2(whatneed).Split(';');
            Array.Sort(listGroups);
            foreach (string item in listGroups)
            {
                if (item == "")
                {
                    continue;
                }
                else
                {
                    listGroup.Add(item);
                    listBoxGroup.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Метод для записи в ComboBox список всех групп
        /// </summary>
        /// <param name="comboBox"></param>
        public void UploadAllGroups(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.AddRange(_Variables.ListAllGroups.ToArray());
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Создание и заполнение источника автодополнения
            AutoCompleteStringCollection autoCompleteCollectionForGroups3 = new AutoCompleteStringCollection();
            autoCompleteCollectionForGroups3.AddRange(_Variables.ListAllGroups.ToArray());

            // Установка источника автодополнения ComboBox
            comboBox.AutoCompleteCustomSource = autoCompleteCollectionForGroups3;
        }

        private void ListGroup_Load(object sender, EventArgs e)
        {
            _Actions.GetGroups();

            uploadListGroup(_Variables._ListGroupForAddEmployeer, listBoxListGroupForEmployees, "ListGroupForEmplyees");
            uploadListGroup(_Variables._ListGroupForAddStudent, listBoxListGroupForStudent, "ListGroupForStudent");

            label7.Text = "*Нажми 2 раза на группу в списке и она буде удалена из списка.";
            label7.BackColor = Color.Red;

            Array.Sort(_Variables.ListAllGroups.ToArray());

            System.Windows.Forms.ComboBox[] list = { comboBoxListGroupForEmployees, comboBoxListGroupForStudents, comboBoxListGroupForSUZsPF };

            foreach (var listTypesGroup in list)
            {
                UploadAllGroups(listTypesGroup);
            }

            label4.Text = $"Количество группу {listBoxListGroupForEmployees.Items.Count}";
            label5.Text = $"Количество группу {listBoxListGroupForStudent.Items.Count}";
            label6.Text = $"Количество группу {listBoxGroupForSUZsPF.Items.Count}";
        }
        /// <summary>
        /// метод для добавления группы в списко групп по умолчанию 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="comboBox"></param>
        /// <param name="label"></param>
        public void AddGroupInList(ListBox listBox, System.Windows.Forms.ComboBox comboBox, Label label)
        {
            string[] allGroups = new string[listBox.Items.Count];

            listBox.Items.CopyTo(allGroups, 0);

            if (Array.Exists(allGroups, group => group == comboBox.Text))
            {
                MessageBox.Show("Такая группа уже добавлена.");
            }
            else
            {
                listBox.Items.Add(comboBox.Text);
                label.Text = $"Количество групп: {listBox.Items.Count}";
            }
            if (comboBox.Text == "")
            {
                MessageBox.Show("Выбери группу.");
            }
        }



        private void buttonAddToListGroupForEmployees_Click(object sender, EventArgs e)
        {
            AddGroupInList(listBoxListGroupForEmployees, comboBoxListGroupForEmployees, label4);
            comboBoxListGroupForEmployees.Text = string.Empty;
        }

        private void buttonAddGroupToListGroupForStudent_Click(object sender, EventArgs e)
        {
            AddGroupInList(listBoxListGroupForStudent, comboBoxListGroupForStudents, label5);
            comboBoxListGroupForStudents.Text = string.Empty;
        }

        private void listBoxListGroupForEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxListGroupForEmployees.SelectedIndex;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                // Удаляем позицию из ListBox
                listBoxListGroupForEmployees.Items.RemoveAt(selectedIndex);
            }
            label4.Text = $"Количество группу {listBoxListGroupForEmployees.Items.Count}";
        }

        private void listBoxListGroupForStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxListGroupForStudent.SelectedIndex;

            // Проверяем, что позиция была выбрана и двойной щелчок выполнен
            if (selectedIndex != -1 && e.Button == MouseButtons.Left)
            {
                // Удаляем позицию из ListBox
                listBoxListGroupForStudent.Items.RemoveAt(selectedIndex);
            }
            label5.Text = $"Количество группу {listBoxListGroupForStudent.Items.Count}";
        }
    }
}
