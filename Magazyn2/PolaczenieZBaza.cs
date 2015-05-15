using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Magazyn2
{
    class PolaczenieZBaza
    {
        private SqlConnection con;

        public PolaczenieZBaza()
        {

            con = new SqlConnection(@"Data Source=LENOVO-KOMPUTER\BAZYMICHALA;Initial Catalog=BazaMagazyn;Integrated Security=True");

        }

        public SqlConnection dajPolaczenie()
        {


            return con;
        }

    }
}
