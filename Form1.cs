using System;
using System.IO;
using System.Windows.Forms;

namespace ViseFormi
{
    public partial class Form1 : Form
    {
        DateTime pocetno = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Form2 student = new Form2();
            DialogResult rez = student.ShowDialog();

            if (rez == DialogResult.OK)
            {
                listBoxStudenti.Items.Add(student.student.ToString());
            }
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.SelectedItems != null)
            {
                listBoxStudenti.Items.Remove(listBoxStudenti.SelectedItem);
            }
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save ListBox Items";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in listBoxStudenti.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }

                        MessageBox.Show("Datoteka spremljena!");
                    }
                }
            }
        }

        private void buttonCitaj_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Open ListBox Items";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxStudenti.Items.Clear();
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    listBoxStudenti.Items.AddRange(lines);

                    MessageBox.Show("Datoteka učitana!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Trenutno: {DateTime.Now.ToLongTimeString()}";

            TimeSpan proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel2.Text = "Proteklo: " + proteklo.Hours.ToString("D2") + ":" + proteklo.Minutes.ToString("D2") + ":" + proteklo.Seconds.ToString("D2");
        }
    }
}
