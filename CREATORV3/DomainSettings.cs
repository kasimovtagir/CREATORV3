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
    public partial class DomainSettings : Form
    {
        public Variables _Variables;
        public Actions _Actions;

        public DomainSettings()
        {
            InitializeComponent();

            _Variables = new Variables();
            _Actions = new Actions(_Variables);
        }

        private void buttonSaveDomainSettings_Click(object sender, EventArgs e)
        {
            _Actions.SaveSettingsV2("netbios", _Variables.NetBios = textBoxNetBios.Text);
            _Actions.SaveSettingsV2("OU", _Variables.OU = comboBoxListOU.Text);
            _Variables.Log.Add($"Произведена смена NetBIOS={_Variables.NetBios}");
            _Variables.Log.Add($"Произведена смена OU={_Variables.OU}");
            this.Close();
        }

        private void DomainSettings_Load(object sender, EventArgs e)
        {
            textBoxNetBios.Text = _Variables.NetBios = _Actions.LoadSettings2("netbios");

            string[] namesOU = _Actions.ListOU(textBoxNetBios.Text).ToArray();
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

            comboBoxListOU.Text = _Variables.OU = _Actions.LoadSettings2("OU");
        }
    }
}
