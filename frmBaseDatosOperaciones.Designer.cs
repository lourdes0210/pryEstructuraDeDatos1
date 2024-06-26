namespace pryEstructuraDeDatos1
{
    partial class frmBaseDatosOperaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyecciónMultiatributo = new System.Windows.Forms.Button();
            this.btnProyecciónSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelecciónConvulción = new System.Windows.Forms.Button();
            this.btnSelecciónSimple = new System.Windows.Forms.Button();
            this.btnSelecciónMultiatributo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnión = new System.Windows.Forms.Button();
            this.btnIntersección = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyecciónMultiatributo);
            this.groupBox1.Controls.Add(this.btnProyecciónSimple);
            this.groupBox1.Location = new System.Drawing.Point(36, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(5, 90);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(177, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyecciónMultiatributo
            // 
            this.btnProyecciónMultiatributo.Location = new System.Drawing.Point(6, 61);
            this.btnProyecciónMultiatributo.Name = "btnProyecciónMultiatributo";
            this.btnProyecciónMultiatributo.Size = new System.Drawing.Size(177, 23);
            this.btnProyecciónMultiatributo.TabIndex = 1;
            this.btnProyecciónMultiatributo.Text = "Proyección multiatributo";
            this.btnProyecciónMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyecciónMultiatributo.Click += new System.EventHandler(this.btnProyecciónMultiatributo_Click);
            // 
            // btnProyecciónSimple
            // 
            this.btnProyecciónSimple.Location = new System.Drawing.Point(6, 32);
            this.btnProyecciónSimple.Name = "btnProyecciónSimple";
            this.btnProyecciónSimple.Size = new System.Drawing.Size(177, 23);
            this.btnProyecciónSimple.TabIndex = 0;
            this.btnProyecciónSimple.Text = "Proyección simple";
            this.btnProyecciónSimple.UseVisualStyleBackColor = true;
            this.btnProyecciónSimple.Click += new System.EventHandler(this.btnProyecciónSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelecciónConvulción);
            this.groupBox2.Controls.Add(this.btnSelecciónSimple);
            this.groupBox2.Controls.Add(this.btnSelecciónMultiatributo);
            this.groupBox2.Location = new System.Drawing.Point(258, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de selección - WHERE";
            // 
            // btnSelecciónConvulción
            // 
            this.btnSelecciónConvulción.Location = new System.Drawing.Point(0, 90);
            this.btnSelecciónConvulción.Name = "btnSelecciónConvulción";
            this.btnSelecciónConvulción.Size = new System.Drawing.Size(194, 23);
            this.btnSelecciónConvulción.TabIndex = 5;
            this.btnSelecciónConvulción.Text = "Selección por convulción";
            this.btnSelecciónConvulción.UseVisualStyleBackColor = true;
            this.btnSelecciónConvulción.Click += new System.EventHandler(this.btnSelecciónConvulción_Click);
            // 
            // btnSelecciónSimple
            // 
            this.btnSelecciónSimple.Location = new System.Drawing.Point(6, 32);
            this.btnSelecciónSimple.Name = "btnSelecciónSimple";
            this.btnSelecciónSimple.Size = new System.Drawing.Size(188, 23);
            this.btnSelecciónSimple.TabIndex = 3;
            this.btnSelecciónSimple.Text = "Selección simple";
            this.btnSelecciónSimple.UseVisualStyleBackColor = true;
            this.btnSelecciónSimple.Click += new System.EventHandler(this.btnSelecciónSimple_Click);
            // 
            // btnSelecciónMultiatributo
            // 
            this.btnSelecciónMultiatributo.Location = new System.Drawing.Point(6, 61);
            this.btnSelecciónMultiatributo.Name = "btnSelecciónMultiatributo";
            this.btnSelecciónMultiatributo.Size = new System.Drawing.Size(188, 23);
            this.btnSelecciónMultiatributo.TabIndex = 4;
            this.btnSelecciónMultiatributo.Text = "Selección multiatributo";
            this.btnSelecciónMultiatributo.UseVisualStyleBackColor = true;
            this.btnSelecciónMultiatributo.Click += new System.EventHandler(this.btnSelecciónMultiatributo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnión);
            this.groupBox3.Controls.Add(this.btnIntersección);
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Location = new System.Drawing.Point(489, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnUnión
            // 
            this.btnUnión.Location = new System.Drawing.Point(6, 43);
            this.btnUnión.Name = "btnUnión";
            this.btnUnión.Size = new System.Drawing.Size(188, 23);
            this.btnUnión.TabIndex = 6;
            this.btnUnión.Text = "Unión";
            this.btnUnión.UseVisualStyleBackColor = true;
            this.btnUnión.Click += new System.EventHandler(this.btnUnión_Click);
            // 
            // btnIntersección
            // 
            this.btnIntersección.Location = new System.Drawing.Point(6, 72);
            this.btnIntersección.Name = "btnIntersección";
            this.btnIntersección.Size = new System.Drawing.Size(188, 23);
            this.btnIntersección.TabIndex = 7;
            this.btnIntersección.Text = "Intersección";
            this.btnIntersección.UseVisualStyleBackColor = true;
            this.btnIntersección.Click += new System.EventHandler(this.btnIntersección_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 101);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(188, 23);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 25);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(677, 186);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(707, 391);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaseDatosOperaciones";
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmBaseDatosOperaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProyecciónSimple;
        private System.Windows.Forms.Button btnProyecciónMultiatributo;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnSelecciónSimple;
        private System.Windows.Forms.Button btnSelecciónMultiatributo;
        private System.Windows.Forms.Button btnSelecciónConvulción;
        private System.Windows.Forms.Button btnUnión;
        private System.Windows.Forms.Button btnIntersección;
        private System.Windows.Forms.Button btnDiferencia;
    }
}