using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArch_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost; Initial Catalog = PersonelApp; User ID = sa; Password = 1";

            #region Insert
            //string sqlText = "insert into Personels values(newid(),'Huseyin','Kakil','huskakil@gmail.com','1114455')";

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.InsertCommand = new SqlCommand(sqlText, connection);

            //connection.Open();
            //sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            //connection.Close();
            #endregion

            #region Update
            //SqlCommand command= new SqlCommand("update Personels set PhoneNumber='7775558899' where PersonelId='3B4284BF-30C5-4F27-8F77-0F0968922386'", connection);
            
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.UpdateCommand = command;

            //connection.Open();
            //sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
            //connection.Close();
            #endregion

            #region Delete
            SqlCommand command = new SqlCommand("delete Personels  where PersonelId='90519E33-4CA8-4B87-9F2E-425B6E6009DB'", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.DeleteCommand = command;

            connection.Open();
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();
            #endregion

        }
    }
}
