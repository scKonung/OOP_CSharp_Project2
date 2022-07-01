using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Chalyi_59022
{
    public partial class FormGlowna : Form
    {
        public FormGlowna()
        {
            InitializeComponent();
        }

        private void bttnKrzeslenie_Figur_Z_pomoca_myszy_Click(object sender, EventArgs e)
        {
            //ukrycie tego formularzu
            this.Hide();
            //pokazywanie nowego formularzu
            Form scFormularz = new KreślenieFigur_Linii_59022();
            scFormularz.Show();
        }

        private void FormGlowna_FormClosed(object sender, FormClosedEventArgs e)
        {   
            //zmaknięcie program
            Application.Exit();
        }

        private void bttnPrezentacja_Figur_Geometrycznych_Click(object sender, EventArgs e)
        {
            //ukrycie tego formularzu
            this.Hide();
            //pokazywanie nowego formularzu
            Form scFormularz = new PrzezentacjaLososwaZeSlajderem();
            scFormularz.Show();
        }
    }
}
