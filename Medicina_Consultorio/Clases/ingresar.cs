using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicina_Consultorio.login;
using static Medicina_Consultorio.Clases.CRUD;
using Medicina_Consultorio.Clases;
using Medicina_Consultorio.Formularios_Citas;
using System.Windows.Forms;
using Medicina_Consultorio.Formularios;



namespace Medicina_Consultorio.login
{
    internal class ingresar
    {
        CRUD crud = new CRUD();
        //INGRESO
        public void found_login()
        {
            if (crud.foundUser(datos.Username, datos.Password) == 1)
            {
                Login_doctores login = new Login_doctores();
                login.Hide();

                Categoria categoria = new Categoria();
                categoria.Show();

            }
        }

}   }
