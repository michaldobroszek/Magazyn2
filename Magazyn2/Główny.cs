using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Magazyn2
{
    public partial class Główny : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        public Główny()
        {
            InitializeComponent();
            comboBox1.Items.Add("Klienci");
            comboBox1.Items.Add("Klienci Zamówienia");
            comboBox1.Items.Add("Produkty");
            comboBox1.Items.Add("Zamówienia");
            comboBox1.Items.Add("Produkty Zamówienia");
        }

        private void wylogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {
                    con.dajPolaczenie().Close();
                }
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Klienci; ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {
                    con.dajPolaczenie().Close();
                }
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Klienci kl join Zamówienia zm on zm.Id_Zamówienia = kl.Id_Klienta ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            if (comboBox1.SelectedIndex == 2)
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {
                    con.dajPolaczenie().Close();
                }
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Produkty ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {
                    con.dajPolaczenie().Close();
                }
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Zamówienia ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            if (comboBox1.SelectedIndex == 4)
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {
                    con.dajPolaczenie().Close();
                }
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select FK_Zamówienie,FK_Produkt,Nazwa,Cena_Netto,ZamawianaIlość FROM Produkty_Zamówienia pz join Produkty pr on pr.Id_Produkt = pz.FK_Produkt  where FK_Zamówienie = (select MAX(FK_Zamówienie) from Produkty_Zamówienia);";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

        }

        private void Główny_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Zamówienia' . Możesz go przenieść lub usunąć.
           // this.zamówieniaTableAdapter.Fill(this.bazaMagazynDataSet.Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty_Zamówienia' . Możesz go przenieść lub usunąć.
          //  this.produkty_ZamówieniaTableAdapter.Fill(this.bazaMagazynDataSet.Produkty_Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty' . Możesz go przenieść lub usunąć.
          //  this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Klienci_Zamówienia' . Możesz go przenieść lub usunąć.
           // this.klienci_ZamówieniaTableAdapter.Fill(this.bazaMagazynDataSet.Klienci_Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Klienci' . Możesz go przenieść lub usunąć.
          //  this.klienciTableAdapter.Fill(this.bazaMagazynDataSet.Klienci);
          //  this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Produkty ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajProdukt dp = new DodajProdukt();
            dp.Show();
        }

        private void bUsun_Click(object sender, EventArgs e)
        {
            Usuń us = new Usuń();
            us.Show();
        }

        private void bEdytuj_Click(object sender, EventArgs e)
        {
            Edytuj ed = new Edytuj();
            ed.Show();
        }

        private void bZamówienie_Click(object sender, EventArgs e)
        {
            Zamówienie za = new Zamówienie();
            za.Show();
            this.Close();
        }

        
    }
}
