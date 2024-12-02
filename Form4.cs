using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViseFormi
{
    public partial class Form4 : Form
    {
        public event Action<string> Izostanci;

        public Form4()
        {
            InitializeComponent();
        }

        private void buttonUpisiIzostanak_Click(object sender, EventArgs e)
        {
            DateTime monthStart = monthCalendar1.SelectionStart;
            DateTime monthEnd = monthCalendar1.SelectionEnd;
            TimeSpan timeSpan = monthEnd - monthStart;

            if (timeSpan.Days < 1)
            {
                MessageBox.Show("Korištenjem tipkom SHIFT odaberite opseg datuma");
            }
            
            string poruka = $"Učenik je izostao {timeSpan.Days} dana. Od {monthStart.ToShortDateString()} do {monthEnd.ToShortDateString()}";

            MessageBox.Show(poruka, "Izostanak");

            Izostanci?.Invoke(poruka);

            Close();
        }
    }
}
