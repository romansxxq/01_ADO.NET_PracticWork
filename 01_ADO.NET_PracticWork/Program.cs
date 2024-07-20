using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _01_ADO.NET_PracticWork
{
    public class ShopDb
    {
        private SqlConnection connection;
        private string connectionString;
        public ShopDb() {
            connectionString = @"workstation id=ShopDb_romans007.mssql.somee.com;packet size=4096;user id=romans__SQLLogin_1;pwd=41yz26xxyo;data source=ShopDb_romans007.mssql.somee.com;persist security info=False;initial catalog=ShopDb_romans007;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        //public void MainMenu()
        //{
        //    switch (switch_on)
        //    {
        //        default:
        //    }
        //}
        public void CreateCustomer(Customers customers)
        {
            string cmdText = $@"INSERT INTO Products
                              VALUES ('{customers.Name}', 
                                      '{customers.Surname}'";
        }
        public List<Customers> ShowCustomers()
        {
            #region Execute Reader
            string cmdText = @"select * from Clients";
            
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.OutputEncoding= Encoding.UTF8;
            List<Customers> customers= new List<Customers>();

            while (reader.Read())
            {
                customers.Add(new Customers()
                {
                    Id = (int)reader[0],
                    Name = (string)reader[1],
                    Surname= (string)reader[2],
                });
            }
            reader.Close();
            return customers;
            #endregion
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopDb db = new ShopDb();
            Customers customer = new Customers()
            {
                Name = "Roman",
                Surname = "Matviychuk"
            };
            var customers = db.ShowCustomers();
            foreach (Customers custo in customers)
            {
                Console.WriteLine(custo.ToString());
            }
            Console.WriteLine();
           

        }
    }
}
