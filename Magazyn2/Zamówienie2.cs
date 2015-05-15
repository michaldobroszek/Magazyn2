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
    public partial class Zamówienie2 : Form
    {
        PolaczenieZBaza con = new PolaczenieZBaza();

        public Zamówienie2()
        {
            InitializeComponent();
        }

        private void bDalej_Click(object sender, EventArgs e)
        {


            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Klienci(Id_Klienta,Nazwa,NIP,REGON) select MAX(Id_Klienta)+1, '" + textNazwaKlienta.Text + "','" + textNip.Text + "','" + textRegon.Text + "'  from Klienci";
            cmd.ExecuteNonQuery();
            con.dajPolaczenie().Close();

            con.dajPolaczenie().Open();
            cmd.CommandText = "INSERT INTO Klienci_Zamówienia(FK_Zamówienia,FK_Klienci) select MAX(Id_Zamówienia),MAX(Id_Klienta) from Zamówienia, Klienci;";
            cmd.ExecuteNonQuery();
            Zamówienie3 zm3 = new Zamówienie3();
            this.Close();
            zm3.Show();
            
        }

        private void bCofnij_Click(object sender, EventArgs e)
        {

            if (con.dajPolaczenie().State == ConnectionState.Open)
            {
                con.dajPolaczenie().Close();
            }
            con.dajPolaczenie().Open();
            SqlCommand cmd = con.dajPolaczenie().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Klienci_Zamówienia where FK_Zamówienia = (Select MAX(FK_Zamówienia) from Klienci_Zamówienia)";
            cmd.ExecuteNonQuery();
           
     
            cmd.CommandText = "delete from Klienci where Id_Klienta = (Select MAX(Id_Klienta) from Klienci)";
            cmd.ExecuteNonQuery();


          
            Zamówienie zm = new Zamówienie();
            this.Close();
        }
    }
}
