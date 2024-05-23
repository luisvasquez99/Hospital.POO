using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.tool.xml.html.HTML;

namespace Medicina_Consultorio.Formularios
{
    public partial class Recetas : Generar
    {
        public Recetas()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvproductos.Columns.Add("Medicina", "Medicina");
            dgvproductos.Columns.Add("Indicacion", "Indicacion");
            dgvproductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvproductos.Columns.Add("Importe", "Importe");
        }
        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Text = Medicina_Consultorio.Properties.Resources.Plantilla.ToString();
            PaginaHTML_Text = PaginaHTML_Text.Replace("@PACIENTE", txtnombres.Text);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@PADECIMIENTO", txtpadecimiento.Text);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Medicina"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Indicacion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["PrecioUnitario"].Value.ToString());
            }
            PaginaHTML_Text = PaginaHTML_Text.Replace("@FILAS", filas);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@TOTAL", total.ToString());

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                var reemplazos = new Dictionary<string, string>
                {
                    { "@PACIENTE", txtnombres.Text },
                    { "@PADECIMIENTO", txtpadecimiento.Text },
                    { "@FECHA", DateTime.Now.ToString("dd/MM/yyyy") },
                    { "@FILAS", filas },
                    { "@TOTAL", total.ToString() }
                };

                CrearPDF(PaginaHTML_Text, reemplazos, savefile.FileName);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];

            row.Cells["Medicina"].Value = txtmedicina.Text;
            row.Cells["Indicacion"].Value = txtindicacion.Text;
            row.Cells["PrecioUnitario"].Value = txtprecio.Text;
            row.Cells["Importe"].Value = decimal.Parse(txtprecio.Text);
        }


        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void atras_Click_1(object sender, EventArgs e)
        {
            Categoria form4 = new Categoria();
            form4.Show();
            this.Hide();

        }
    }
}



