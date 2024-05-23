using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Medicina_Consultorio;
using Medicina_Consultorio.Formularios;

namespace Medicina_Consultorio.Formularios_Citas
{
    public partial class citas : Generar
    {
        private coneccion dbConnection = new coneccion();

        public citas()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Rellenar combobox de doctores y sucursales desde la base de datos
            FillDoctorComboBox();
            FillSucursalComboBox();
        }

        private void FillDoctorComboBox()
        {
            using (SqlConnection conn = dbConnection.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_doctor, nombre FROM doctores", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDoctor.Items.Add(new { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                        }
                    }
                }
                conn.Close();
            }
            comboBoxDoctor.DisplayMember = "Name";
            comboBoxDoctor.ValueMember = "Id";
        }

        private void FillSucursalComboBox()
        {
            using (SqlConnection conn = dbConnection.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_sucursal, sucursal FROM sucursales", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxSucursal.Items.Add(new { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                        }
                    }
                }
                conn.Close();
            }
            comboBoxSucursal.DisplayMember = "Name";
            comboBoxSucursal.ValueMember = "Id";
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
                    { "@MEDICO", ((dynamic)comboBoxDoctor.SelectedItem).Name },
                    { "@CLINICA", ((dynamic)comboBoxSucursal.SelectedItem).Name },
                    { "@FECHA1", DateTime.Now.ToString("dd/MM/yyyy") },
                    { "@REF", textrefe.Text },
                    { "@FECHAR", txtrecep.Text },
                    { "@PAC", txtnombrepas.Text },
                    { "@EDAD", txtedad.Text },
                    { "@IND", txtindicacion.Text },
                    { "@TEL", txtel.Text }
                };

                CrearPDF(plantilla, reemplazos, savefile.FileName);

                // Guardar la cita en la base de datos
                SaveCitaToDatabase(txtnombrepas.Text, (int)((dynamic)comboBoxDoctor.SelectedItem).Id, (int)((dynamic)comboBoxSucursal.SelectedItem).Id, txtindicacion.Text, int.Parse(txtedad.Text), int.Parse(txtel.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
            this.Hide();
        }

        private void SaveCitaToDatabase(string paciente, int idDoctor, int idSucursal, string indicaciones, int edad, int telefono)
        {
            using (SqlConnection conn = dbConnection.connect())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO citasgeneradas (fecha, paciente, edad, indicaciones, telefono, id_doctor, id_sucursal) VALUES (@Fecha, @Paciente, @Edad, @Indicaciones, @Telefono, @IdDoctor, @IdSucursal)", conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Paciente", paciente);
                    cmd.Parameters.AddWithValue("@Edad", edad);
                    cmd.Parameters.AddWithValue("@Indicaciones", indicaciones);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@IdDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void txtclinica_TextChanged(object sender, EventArgs e) { }
    }
}

