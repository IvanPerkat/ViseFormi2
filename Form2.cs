using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ViseFormi
{
    public partial class Form2 : Form
    {
        DateTime pocetno = DateTime.Now;

        public Form2()
        {
            InitializeComponent();

            comboBoxSmjer.Items.Add("Programer");
            comboBoxSmjer.Items.Add("Sistem administrator");
            comboBoxSmjer.Items.Add("Mrežni administrator");

            timer1.Tick += timer1_Tick;
        }

        public Class1 student { get; set; }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            student = new Class1(
                textBoxIme.Text,
                textBoxPrezime.Text,
                textBoxIndeks.Text,
                comboBoxSmjer.SelectedItem.ToString(),
                dateTimePickerDatumRodjenja.Value,
                groupBoxVrstaStudija.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Trenutno: {DateTime.Now.ToLongTimeString()}";

            TimeSpan proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel2.Text = "Proteklo: " + proteklo.Hours.ToString("D2") + ":" + proteklo.Minutes.ToString("D2") + ":" + proteklo.Seconds.ToString("D2");
        }
    }
}
