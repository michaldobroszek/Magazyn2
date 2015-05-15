using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn2
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void bZaloguj_Click(object sender, EventArgs e)
        {
            string haslo = textHaslo.Text;
            if (sprawdzDaneLogowania(haslo))
            {

                MessageBox.Show("Zalogowano");

                this.Hide();
               Główny gl = new Główny();
                gl.Show();


            }
            else
                MessageBox.Show("Niepoprawne dane logowania");


        }

        public bool sprawdzDaneLogowania(string haslo)
        {

            if (haslo == "admin")
            {
                return true;
            }

            else
                return false;
        }

        private void bPrzegladaj_Click(object sender, EventArgs e)
        {
        

            MessageBox.Show("Tryb Przeglądania");

            this.Hide();
           Przeglądaj pr = new Przeglądaj();
            pr.Show();

        }

        private void bZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }

    }

