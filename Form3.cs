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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            comboBoxVrsta.Items.Add("Roboto");
            comboBoxVrsta.Items.Add("Poppins");
            comboBoxVrsta.Items.Add("Arial");

            comboBoxVelicina.Items.Add(10);
            comboBoxVelicina.Items.Add(12);
            comboBoxVelicina.Items.Add(14);

            comboBoxBoja.Items.Add("Crna");
            comboBoxBoja.Items.Add("Bijela");
            comboBoxBoja.Items.Add("Crvena");
        }

        public Class2 font {  get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            font = new Class2(
                comboBoxVrsta.SelectedItem.ToString(),
                comboBoxBoja.SelectedItem.ToString(),
                (int)comboBoxVelicina.SelectedItem
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Izađi";
            string caption = "Jeste li sigurni da želite izaći?";
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
    }
}
