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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Boton que lleva al formulario de "Especialidades"
        private void button1_Click(object sender, EventArgs e)
        {
            Login_doctores especialidadForm = new Login_doctores();

            // Mostrar el otro formulario
            especialidadForm.ShowDialog();
        }
    }
}
