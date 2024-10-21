using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViseFormi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBoxSmjer.Items.Add("Programer");
            comboBoxSmjer.Items.Add("Sistem administrator");
            comboBoxSmjer.Items.Add("Mrežni administrator");
        }

        public Class1 student {  get; set; }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            student = new Class1(
                textBoxIme.Text,
                textBoxPrezime.Text,
                textBoxIndeks.Text,
                comboBoxSmjer.SelectedItem.ToString(),
                dateTimePickerDatumRodjenja.Value,
                groupBoxVrstaStudija.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text
            ); 

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
