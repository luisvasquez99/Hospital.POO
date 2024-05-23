using Medicina_Consultorio.Formularios_Citas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicina_Consultorio.Formularios
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void Citas_Click(object sender, EventArgs e)
        {
            citas form2 = new citas();
            form2.Show();
            this.Hide();
        }

        private void Recetas_Click(object sender, EventArgs e)
        {
            Recetas form3 = new Recetas();
            form3.Show();
            this.Hide();
        }
    }
}
