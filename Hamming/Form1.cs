using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamming
{
    public partial class Form1 : Form
    {
        Hamming_Class hc = new Hamming_Class();
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            jeden_blad.Enabled = false;
            dwa_bledy.Enabled = false;
            Wykryj_bledy.Enabled = false;
            Input_error.Enabled = false;
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            hc.wczytaj_kod(input_data.Text, comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex == 0)
            {
                jeden_blad.Enabled = true;
                Input_error.Enabled = true;
                dwa_bledy.Enabled = false;

            }
            else
            {
                dwa_bledy.Enabled = true;
                Input_error.Enabled = true;
                jeden_blad.Enabled = false;
            }
            Kod_nadmiarowy.Text = hc.oblicz_kod_nadmiarowy();
            Macierz_pokaz.Text = hc.pokaz_macierz();
            Input_error.Text = input_data.Text + Kod_nadmiarowy.Text;
            Wykryj_bledy.Enabled = true;
        }

        private void jeden_blad_Click(object sender, EventArgs e)
        {
            Input_error.Text = hc.zrob_jeden_blad();
        }

        private void Wykryj_bledy_Click(object sender, EventArgs e)
        {
            hc.wczytaj_odpowiedz(Input_error.Text);
            hc.oblicz_kod_nadmiarowy_dla_odpowiedzi();
            bit_zmieniony.Text = hc.sprawdz_syndrom();
        }

        private void dwa_bledy_Click(object sender, EventArgs e)
        {
            Input_error.Text = hc.genruj_dwa_bledy();
        }
    }
}
