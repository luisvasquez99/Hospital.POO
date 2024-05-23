using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

 
namespace Medicina_Consultorio
{
    internal class coneccion
    {
        public SqlConnection connect()
        {
            string query = @"Data Source=LAPTOPCAP;Initial Catalog=admin_hospital;Integrated Security=true";
            SqlConnection connect = new SqlConnection(query);
            connect.Open();
            return connect;
        }

        public SqlConnection disconnect()
        {
            string query = @"Data Source=LAPTOPCAP;Initial Catalog=admin_hospital;Integrated Security=true";
            SqlConnection disconnect = new SqlConnection(query);
            disconnect.Close();
            return disconnect;
        }
    }
}
