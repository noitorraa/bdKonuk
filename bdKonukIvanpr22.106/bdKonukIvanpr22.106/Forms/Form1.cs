using bdKonukIvanpr22._106.Forms;
using bdKonukIvanpr22._106.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdKonukIvanpr22._106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            Disciplini disp = new Disciplini();
            disp.Show();
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            Faculteti fac = new Faculteti();    
            fac.Show();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            Gruppi gruppi = new Gruppi();
            gruppi.Show();
        }

        private void btnKaf_Click(object sender, EventArgs e)
        {
            Kafedra kafedra = new Kafedra();
            kafedra.Show();
        }

        private void btnPodTab_Click(object sender, EventArgs e)
        {
            PodVed podVed = new PodVed();
            podVed.Show();
        }

        private void btnPrep_Click(object sender, EventArgs e)
        {
            Prepodavateli prepodavateli = new Prepodavateli();
            prepodavateli.Show();
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            Studenti studenti = new Studenti();
            studenti.Show();
        }

        private void btnVed_Click(object sender, EventArgs e)
        {
            Vedomosti vedomosti = new Vedomosti();
            vedomosti.Show();
        }
    }
}
