using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.tool.xml.html.HTML;
using Medicina_Consultorio.Formularios;

namespace Medicina_Consultorio.Formularios_Citas
{
    public partial class citas : Generar
    {
        public citas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndescargar3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string plantilla = Properties.Resources.Plantilla2;
                var reemplazos = new Dictionary<string, string>
                {
                    { "@MEDICO", txtnombremedico.Text },
                    { "@CLINICA", txtclinica.Text },
                    { "@FECHA1", DateTime.Now.ToString("dd/MM/yyyy") },
                    { "@REF", textrefe.Text },
                    { "@FECHAR", txtrecep.Text },
                    { "@PAC", txtnombrepas.Text },
                    { "@EDAD", txtedad.Text },
                    { "@IND", txtindicacion.Text },
                    { "@TEL", txtel.Text }
                };

                CrearPDF(plantilla, reemplazos, savefile.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
            this.Hide();

        }
    }
}

