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
    public partial class Zamówienie : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        List<String> listaId = new List<String>();
        List<String> listaIlosci = new List<String>();

        public Zamówienie()
        {
            InitializeComponent();
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
            dataGridViewProdukty.DataSource = dt;

            dokonajZamowienia();


        }

        private void Zamówienie_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Zamówienia' . Możesz go przenieść lub usunąć.
            this.zamówieniaTableAdapter.Fill(this.bazaMagazynDataSet.Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty_Zamówienia' . Możesz go przenieść lub usunąć.
            this.produkty_ZamówieniaTableAdapter.Fill(this.bazaMagazynDataSet.Produkty_Zamówienia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);

        }

        private void dokonajZamowienia()
        {

            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Zamówienia(Id_Zamówienia) select MAX(Id_Zamówienia)+1  from Zamówienia";
            cmd.ExecuteNonQuery();


        }

        private void dataGridViewProdukty_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridViewProdukty.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                textId.Text = row.Cells["idProduktDataGridViewTextBoxColumn"].Value.ToString();
                textNazwa.Text = row.Cells["nazwaDataGridViewTextBoxColumn"].Value.ToString();
                textIlosc.Text = row.Cells["ilośćDataGridViewTextBoxColumn"].Value.ToString();
                textCenaNetto.Text = row.Cells["cenaNettoDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void bDodajDoKoszyka_Click(object sender, EventArgs e)
        {

            int iloscZBazy;
            int iloscZwpisania;
            int anInteger3;
            iloscZBazy = Convert.ToInt32(textIlosc.Text);


            iloscZwpisania = Convert.ToInt32(textZamawianaIlosc.Text);


            if (iloscZBazy >= iloscZwpisania)
            {
                try
                {
                    if (con.dajPolaczenie().State == ConnectionState.Open)
                    {
                        con.dajPolaczenie().Close();
                    }

                    con.dajPolaczenie().Open();
                    SqlCommand cmd = con.dajPolaczenie().CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Produkty_Zamówienia(FK_Zamówienie,FK_Produkt,ZamawianaIlość) select MAX(Id_Zamówienia), '" + textId.Text + "','"+textZamawianaIlosc.Text+"'  from Zamówienia";
                    cmd.ExecuteNonQuery();

                    

                    MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    anInteger3 = iloscZBazy - iloscZwpisania;
                    textIlosc.Text = anInteger3.ToString();

                    cmd.CommandText = "UPDATE Produkty SET Ilość =@ilosc  WHERE Id_Produkt =@id  ;";
                    cmd.Parameters.AddWithValue("@ilosc", textIlosc.Text);
                    cmd.Parameters.AddWithValue("@id", textId.Text);
                    cmd.ExecuteNonQuery();

                    listaId.Add(textId.Text);
                    listaIlosci.Add(textIlosc.Text);


                    foreach (String prime in listaId)// Loop with for.
                    {
                        foreach (String prime2 in listaIlosci)
                        {
                            Console.WriteLine(prime);
                            Console.WriteLine(prime2);
                        }
                    }

                    this.textZamawianaIlosc.Text = "0";


                    cmd.CommandText = "Select FK_Zamówienie,FK_Produkt,Nazwa,Cena_Netto,ZamawianaIlość FROM Produkty_Zamówienia pz join Produkty pr on pr.Id_Produkt = pz.FK_Produkt  where FK_Zamówienie = (select MAX(FK_Zamówienie) from Produkty_Zamówienia);  ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridViewProduktyZamowienia.DataSource = dt;



                    cmd.CommandText = "select * from Produkty";
                    cmd.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    da2.Fill(dt2);
                    dataGridViewProdukty.DataSource = dt2;


                }
                catch
                {
                    MessageBox.Show("Produkt znajduje sie juz w  koszyku");
                }





            }
            else
            {
                MessageBox.Show("Brak takiej ilości produktu w magazynie");

            }
        }

        private void bAnuluj_Click(object sender, EventArgs e)
        {
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }


            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Produkty_Zamówienia where FK_Zamówienie=(Select MAX(FK_Zamówienie) from Produkty_Zamówienia)";

            cmd.ExecuteNonQuery();

            con.dajPolaczenie().Close();

            con.dajPolaczenie().Open();

            cmd.CommandText = "delete from Zamówienia where Id_Zamówienia = (Select MAX(Id_Zamówienia) from Zamówienia) ";
            cmd.ExecuteNonQuery();
            con.dajPolaczenie().Close();
            foreach (String prime in listaId)// Loop with for.
            {
                foreach (String prime2 in listaIlosci)
                {
                    con.dajPolaczenie().Open();

                    cmd.CommandText = "UPDATE Produkty SET Ilość ='"+ prime2+"' WHERE Id_Produkt = '"+ prime+"'  ;";
              
                    cmd.ExecuteNonQuery();
                    con.dajPolaczenie().Close();

                }
            }

            listaId.Clear();
            listaIlosci.Clear();

            this.Close();

        }

        private void bWprowadzKlienta_Click(object sender, EventArgs e)
        {
            Zamówienie2 zm2 = new Zamówienie2();
            zm2.Show();
            this.Close();
        }
    }
}
