namespace Medicina_Consultorio.Formularios
{
    partial class Recetas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recetas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmedicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtindicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpadecimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Paciente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(121, 57);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(191, 22);
            this.txtnombres.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Medicina";
            // 
            // txtmedicina
            // 
            this.txtmedicina.Location = new System.Drawing.Point(121, 115);
            this.txtmedicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtmedicina.Name = "txtmedicina";
            this.txtmedicina.Size = new System.Drawing.Size(191, 22);
            this.txtmedicina.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Indicacion";
            // 
            // txtindicacion
            // 
            this.txtindicacion.Location = new System.Drawing.Point(121, 180);
            this.txtindicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtindicacion.Name = "txtindicacion";
            this.txtindicacion.Size = new System.Drawing.Size(184, 22);
            this.txtindicacion.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Padecimiento";
            // 
            // txtpadecimiento
            // 
            this.txtpadecimiento.Location = new System.Drawing.Point(567, 60);
            this.txtpadecimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtpadecimiento.Name = "txtpadecimiento";
            this.txtpadecimiento.Size = new System.Drawing.Size(191, 22);
            this.txtpadecimiento.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 108;
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.ColumnHeadersHeight = 30;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.Color.DimGray;
            this.dgvproductos.Location = new System.Drawing.Point(95, 225);
            this.dgvproductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvproductos.MultiSelect = false;
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvproductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvproductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproductos.RowTemplate.Height = 30;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductos.Size = new System.Drawing.Size(636, 305);
            this.dgvproductos.TabIndex = 110;
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Location = new System.Drawing.Point(375, 551);
            this.btndescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(175, 33);
            this.btndescargar.TabIndex = 111;
            this.btndescargar.Text = "Terminar e Imprimir";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(596, 553);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(135, 31);
            this.btnagregar.TabIndex = 112;
            this.btnagregar.Text = "Generar Receta";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // atras
            // 
            this.atras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atras.BackgroundImage")));
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.atras.Location = new System.Drawing.Point(743, 2);
            this.atras.Margin = new System.Windows.Forms.Padding(4);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(51, 39);
            this.atras.TabIndex = 147;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "Precio $:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(567, 121);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(61, 22);
            this.txtprecio.TabIndex = 149;
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 597);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpadecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtindicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmedicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label1);
            this.Name = "Recetas";
            this.Text = "Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmedicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtindicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpadecimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
    }
}