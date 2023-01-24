using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog = PersonelApp; User ID = sa; Password = 1";


            DataTable dt = new DataTable();
         

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Personels", connection);

            adapter.Fill(dt);
          

            Console.WriteLine($"{connection.State}");
            Console.WriteLine(dt.ToString());





        }
    }
}
