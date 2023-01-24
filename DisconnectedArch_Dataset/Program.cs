using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArch_Dataset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog = PersonelApp; User ID = sa; Password = 1";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Personels; Select * From SystemUser", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "ExampleDset");
            Console.ReadLine();
        }
    }
}
