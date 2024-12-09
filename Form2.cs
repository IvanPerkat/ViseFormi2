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

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 5;
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
                groupBoxVrstaStudija.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                trackBar1.Value.ToString()
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Otkaži promjene?";
            string caption = "Jeste li sigurni da želite otkazati promjene?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    DialogResult = DialogResult.Cancel;
                    Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Trenutno: {DateTime.Now.ToLongTimeString()}";

            TimeSpan proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel2.Text = "Proteklo: " + proteklo.Hours.ToString("D2") + ":" + proteklo.Minutes.ToString("D2") + ":" + proteklo.Seconds.ToString("D2");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxGodina.Text = trackBar1.Value.ToString();
        }
    }
}
