using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace Medicina_Consultorio.Clase_Conexión_DB
{
    internal class conexion_bd
    {


public class BaseDatos
    {
        private string connectionString;

        public BaseDatos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Username = @username AND Password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", usuario.Username);
                command.Parameters.AddWithValue("@password", usuario.Password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }

}
}
