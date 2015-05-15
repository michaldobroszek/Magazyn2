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
    public partial class Edytuj : Form
    {

        PolaczenieZBaza con = new PolaczenieZBaza();


        public Edytuj()
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
            dataGridView1.DataSource = dt;
        }

        private void bEdytuj_Click(object sender, EventArgs e)
        {
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            try
            {

                if ((String.IsNullOrEmpty(textNazwa.Text)) || (String.IsNullOrEmpty(textIlosc.Text))||(String.IsNullOrEmpty(textCenaNetto.Text)))
                {
                    MessageBox.Show("Puste pole");
                }
                else
                {
                    con.dajPolaczenie().Open();
                    SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Produkty set Nazwa='" + this.textNazwa.Text + "',Ilość='" + this.textIlosc.Text + "'where Id_Produkt='" + this.textId.Text + "' ;";
                    cmd.ExecuteNonQuery();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 1)
                    {
                        MessageBox.Show("Zmieniono dane produktu!");
                    }
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Błąd: Nie ma takiego id !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Id Produktu, Ilość musi być liczbą");
            }

        }

        private void bWyjdz_Click(object sender, EventArgs e)
        {
            con.dajPolaczenie().Close();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
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

        private void Edytuj_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);

        }
    }
}
