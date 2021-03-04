using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n09_mag_gui
{
    public partial class FormTowary : Form
    {
        private Dane Magazyn = new Dane();
        public FormTowary()
        {
            InitializeComponent();
        }

        private void buttonListaTowarow_Click(object sender, EventArgs e)
        {
            List<Towar> lista = Magazyn.PodajTowary();
            if (lista.Count > 0)
            {
                foreach (Towar t in lista)
                {
                    this.listBoxTowary.Items.Add(t.ToString());
                }
            }
            else
            {
                MessageBox.Show("Brak towarów"); 
            }

        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            this.listBoxTowary.Items.Clear();
        }
    }
}
