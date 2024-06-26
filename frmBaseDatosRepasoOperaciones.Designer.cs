namespace pryEstructuraDeDatos1
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(11, 211);
            this.dgvOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.Size = new System.Drawing.Size(734, 228);
            this.dgvOperaciones.TabIndex = 9;
            // 
            // lblOperacion
            // 
            this.lblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperacion.Location = new System.Drawing.Point(11, 45);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(734, 154);
            this.lblOperacion.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(632, 4);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 32);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.Items.AddRange(new object[] {
            "Unión de Autores",
            "Unión de Paises",
            "Unión de Idiomas",
            "Diferencia de Idiomas",
            "Diferencia de Autores",
            "Intersección de Idiomas",
            "Intersección de Paises",
            "Selección Simple de Año",
            "Selección Simple de Cantidad",
            "Selección Multiatributo con el operador AND ",
            "Selección Multiatributo con el operador OR",
            "Seleccion Multiatributo por convolución ",
            "Proyección Simple de Titulos",
            "Proyección Simple de Autores",
            "Proyección Simple por Paises",
            "Proyección Simple por Idioma",
            "Proyección Multiatributo Titulo y Cantidad",
            "Proyección Multiatributo Titulo y Precio",
            "Juntar Libros e Idiomas",
            "Juntar Libros y Autores"});
            this.cbOperaciones.Location = new System.Drawing.Point(280, 11);
            this.cbOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(331, 21);
            this.cbOperaciones.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operaciones a realizar en la base de datos";
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(763, 449);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cbOperaciones);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.Text = "frmBaseDatosRepasoOperaciones";
            this.Load += new System.EventHandler(this.frmBaseDatosRepasoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbOperaciones;
        private System.Windows.Forms.Label label1;
    }
}