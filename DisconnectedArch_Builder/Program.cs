using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArch_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog = PersonelApp; User ID = sa; Password = 1";
            SqlDataAdapter adapter = new SqlDataAdapter("select * from personels",connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet dataSet = new DataSet("MyDB");
            adapter.Fill(dataSet); // Create Datatable
            dataSet.Tables[0].TableName = "MyPersonels";
            Console.WriteLine($"DB Name: {dataSet.DataSetName}  Table Name: {dataSet.Tables[0].TableName}");


        }
    }
}
