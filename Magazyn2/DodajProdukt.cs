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
    public partial class DodajProdukt : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        public DodajProdukt()
        {
            InitializeComponent();
        }

        private void DodajProdukt_Load(object sender, EventArgs e)
        {
            
            this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);
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

        private void bDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.dajPolaczenie().State == ConnectionState.Open)
                {


                    con.dajPolaczenie().Close();
                }




                if ((String.IsNullOrEmpty(textNazwa.Text)) || (String.IsNullOrEmpty(textIlosc.Text)))
                {
                    MessageBox.Show("Puste pole");
                }
                else
                {
                    con.dajPolaczenie().Open();
                    SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Produkty (Id_Produkt,Nazwa,Ilość,Cena_Netto) SELECT MAX(Id_Produkt)+1 , '" + textNazwa.Text + "','" + textIlosc.Text + "','"+textCenaNetto.Text+"' FROM Produkty";
                    cmd.ExecuteNonQuery();
                 
                    
                    MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Pole: Ilość musi być liczbą");
            }

        }

        private void bWyjdz_Click(object sender, EventArgs e)
        {
            con.dajPolaczenie().Close();
            this.Close();
        }
    }
}
