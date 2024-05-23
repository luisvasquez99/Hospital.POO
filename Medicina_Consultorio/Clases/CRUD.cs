using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicina_Consultorio.Clases;
using static Medicina_Consultorio.datos;


namespace Medicina_Consultorio.Clases
{
    internal class CRUD
    {


        //Login
        coneccion coneccion = new coneccion();
        public int foundUser(string username, string password)
        {
            try
            {
                coneccion.connect();
                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @username AND contraseña = @password";
                SqlCommand cmd = new SqlCommand(query, coneccion.connect());
                cmd.Parameters.AddWithValue("@username", datos.Username);
                cmd.Parameters.AddWithValue("@password", datos.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor rellenar todos los campos", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (count < 1)
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return count;
            }
            catch (Exception bug)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR AL CONECTAR A LA BASE DE DATOS " + bug.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                coneccion.disconnect();
            }
        }
    }
} 