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
    public partial class Zamówienie3 : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();
        public Zamówienie3()
        {
            InitializeComponent();
          /*  if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Klienci where Id_Klienta = ( Select MAX(Id_Klienta) from Klienci) ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewKlient.DataSource = dt;
            con.dajPolaczenie().Close();*/

            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
           
            cmd.CommandText = "Select FK_Zamówienie,FK_Produkt,Nazwa,Cena_Netto,ZamawianaIlość FROM Produkty_Zamówienia pz join Produkty pr on pr.Id_Produkt = pz.FK_Produkt  where FK_Zamówienie = (select MAX(FK_Zamówienie) from Produkty_Zamówienia);  ";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            dataGridViewZamowioneProdukty.DataSource = dt2;

           
        }

        private void Zamówienie3_Load(object sender, EventArgs e)
        {
            
        }

        private void bZamow_Click(object sender, EventArgs e)
        {
            Główny gl = new Główny();
            gl.Show();

            
            this.Close();
        }

        private void bCofnij_Click(object sender, EventArgs e)
        {
            Zamówienie2 zm2 = new Zamówienie2();
            zm2.Show();
            this.Close();

        }
    }
}
