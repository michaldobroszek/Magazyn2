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
    public partial class Usuń : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        public Usuń()
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

        private void bUsun_Click(object sender, EventArgs e)
        {
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            try
            {
                con.dajPolaczenie().Open();
                SqlCommand cmd = con.dajPolaczenie().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Produkty where Id_Produkt='" + this.textIdProdukt.Text + "' ;";

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    MessageBox.Show("Usunieto produkt!");

                    cmd.CommandText = "select * from Produkty ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                if (affectedRows == 0)
                {
                    MessageBox.Show("Błąd: Nie ma takiego id !");
                }
            }
            catch
            {
                MessageBox.Show("Id produktu produktu mussi być liczbą");
            }

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

                textIdProdukt.Text = row.Cells["idProduktDataGridViewTextBoxColumn"].Value.ToString();

            }

        }

        private void Usuń_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.bazaMagazynDataSet.Produkty);

        }

        private void bWyjdz_Click(object sender, EventArgs e)
        {
            con.dajPolaczenie().Close();
            this.Close();
        }
    }
}
