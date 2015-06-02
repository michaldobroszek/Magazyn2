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
    public partial class UsuńKlienta : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        String temp;
        public UsuńKlienta()
        {
            InitializeComponent();
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Klienci";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void UsuńKlienta_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bazaMagazynDataSet.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.bazaMagazynDataSet.Klienci);

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

                temp = row.Cells["idKlientaDataGridViewTextBoxColumn"].Value.ToString();
        }
    }

        private void bUsuń_Click(object sender, EventArgs e)
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
                cmd.CommandText = "delete from Klienci where Id_Klienta='" + this.temp + "' ;";

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    MessageBox.Show("Usunieto Klienta!");

                    cmd.CommandText = "select * from Klienci ";
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
                MessageBox.Show("Klient ten powiązany jest z Zamówieniem");
            }
        }

        private void bWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
