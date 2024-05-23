using Medicina_Consultorio.Clases;
using Medicina_Consultorio.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicina_Consultorio
{
    public partial class Login_doctores : Form
    {
        public Login_doctores()
        {
            InitializeComponent();
            textBoxpassword.PasswordChar = '*';
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar ingresar = new ingresar();
            datos.Username = textBoxusuario.Text;
            datos.Password = textBoxpassword.Text;
            ingresar.found_login();

            



        }
    }
}
