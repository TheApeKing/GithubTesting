using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Configuration;

namespace GithubTesting
{
    public class DataAccess
    {
        private string connString = ConfigurationManager.ConnectionStrings["northwind"].ToString();

        public List<Customer> GetCustomers()
        {
            List<Customer> customers;
            using (IDbConnection conn = new SqlConnection(connString))
            {
                customers = conn.Query<Customer>("select * from Customers").ToList();
                return customers;
            }
        }
    }
}
