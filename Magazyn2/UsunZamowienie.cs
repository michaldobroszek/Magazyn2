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
    public partial class UsunZamowienie : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();
        String tempIdKlienta;
        String tempIdZamowienia;


        public UsunZamowienie()
        {
            InitializeComponent();
            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select FK_Zamówienia,FK_Klienci,Nazwa,NIP,REGON from Klienci_Zamówienia kz join Klienci kl on kl.Id_Klienta =kz.FK_Klienci;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cmd.CommandText = "delete from Klienci_Zamówienia where FK_Zamówienia='" + this.tempIdZamowienia + "' ;";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from Produkty_Zamówienia where Fk_Zamówienie='" + this.tempIdZamowienia + "' ;";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from Zamówienia where Id_Zamówienia='" + this.tempIdZamowienia + "' ;";
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Usunieto Zamówienie!");

                    cmd.CommandText = "select FK_Zamówienia,FK_Klienci,Nazwa,NIP,REGON from Klienci_Zamówienia kz join Klienci kl on kl.Id_Klienta =kz.FK_Klienci;  ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

               
                
                  
                
            }
            catch
            {
                MessageBox.Show(" ten powiązany jest z Zamówieniem");
            }
        }

      

        private void UsunZamowienie_Load(object sender, EventArgs e)
        {
           

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

                tempIdZamowienia = row.Cells[0].Value.ToString();
              tempIdKlienta = row.Cells[1].Value.ToString();

             
            }
        }
    }

       
}
