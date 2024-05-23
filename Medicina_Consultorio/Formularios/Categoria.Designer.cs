namespace Medicina_Consultorio.Formularios
{
    partial class Categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.Citas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Recetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Citas
            // 
            this.Citas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Citas.BackgroundImage")));
            this.Citas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Citas.Location = new System.Drawing.Point(62, 63);
            this.Citas.Margin = new System.Windows.Forms.Padding(4);
            this.Citas.Name = "Citas";
            this.Citas.Size = new System.Drawing.Size(167, 122);
            this.Citas.TabIndex = 5;
            this.Citas.UseVisualStyleBackColor = true;
            this.Citas.Click += new System.EventHandler(this.Citas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Citas Médicas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recetas Médicas";
            // 
            // Recetas
            // 
            this.Recetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Recetas.BackgroundImage")));
            this.Recetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Recetas.Location = new System.Drawing.Point(62, 260);
            this.Recetas.Margin = new System.Windows.Forms.Padding(4);
            this.Recetas.Name = "Recetas";
            this.Recetas.Size = new System.Drawing.Size(175, 148);
            this.Recetas.TabIndex = 8;
            this.Recetas.UseVisualStyleBackColor = true;
            this.Recetas.Click += new System.EventHandler(this.Recetas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.Recetas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Citas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Citas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Recetas;
    }
}