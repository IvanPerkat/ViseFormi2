using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace ViseFormi
{
    public partial class Form1 : Form
    {
        DateTime pocetno = DateTime.Now;
        string izostanciFilePath = "C:\\Users\\ucenik\\Downloads";

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Form2 student = new Form2();
            DialogResult result = student.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBoxStudenti.Items.Add(student.student.ToString());
            }
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.Items.Count > 0)
            {
                string message = "Obriši studenta?";
                string caption = "Jeste li sigurni da želite obrisati studenta?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (listBoxStudenti.SelectedItems != null)
                        {
                            listBoxStudenti.Items.Remove(listBoxStudenti.SelectedItem);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nema studenta za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.Items.Count > 0)
            {
                string message = "Obriši sve?";
                string caption = "Jeste li sigurni da želite obrisati sve studente?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        listBoxStudenti.Items.Clear();
                        break;
                    case DialogResult.No:
                        break; 
                }
            }
            else
            {
                MessageBox.Show("Nema studenata za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messgae = "Izađi iz aplikacije?";
            string caption = "Izađi";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(messgae, caption, buttons, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    Close(); 
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 font = new Form3();
            DialogResult result = font.ShowDialog();

            if (result == DialogResult.Yes)
            {
                
            }
        }

        private void buttonChrome_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";

            Process.Start(path);
        }

        private void buttonExcele_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";

            Process.Start(path);
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("chrome.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            startInfo.Arguments = "https://eu.wargaming.net/shop/wot/vehicles/";

            Process.Start(startInfo);
        }

        private void buttonUpišiIzostanak_Click(object sender, EventArgs e)
        {
            Form4 upisiIzostanak = new Form4();

            upisiIzostanak.Izostanci += PrikaziIzostanak;

            DialogResult result = upisiIzostanak.ShowDialog();
        }

        private void PrikaziIzostanak(string izostanak)
        {
            File.AppendAllText(izostanciFilePath, izostanak + Environment.NewLine);

            MessageBox.Show("Izostanak je zabilježen!");

            Process.Start("notepad.exe", izostanciFilePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
