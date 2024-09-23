namespace Vista
{
    partial class frmExportar
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
            this.lblNumeroFicha = new System.Windows.Forms.Label();
            this.txtNumeroFicha = new System.Windows.Forms.TextBox();
            this.dgvExportar = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblCorregimiento = new System.Windows.Forms.Label();
            this.txtCorregimiento = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblManzana = new System.Windows.Forms.Label();
            this.txtManzana = new System.Windows.Forms.TextBox();
            this.lblPredio = new System.Windows.Forms.Label();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.txtUnidadPredial = new System.Windows.Forms.TextBox();
            this.lblUnidadPredial = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.NumeroFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corregimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manzana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadPredial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroFicha
            // 
            this.lblNumeroFicha.AutoSize = true;
            this.lblNumeroFicha.Location = new System.Drawing.Point(12, 30);
            this.lblNumeroFicha.Name = "lblNumeroFicha";
            this.lblNumeroFicha.Size = new System.Drawing.Size(76, 13);
            this.lblNumeroFicha.TabIndex = 0;
            this.lblNumeroFicha.Text = "Numero Ficha:";
            // 
            // txtNumeroFicha
            // 
            this.txtNumeroFicha.Location = new System.Drawing.Point(107, 23);
            this.txtNumeroFicha.Name = "txtNumeroFicha";
            this.txtNumeroFicha.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroFicha.TabIndex = 1;
            // 
            // dgvExportar
            // 
            this.dgvExportar.AllowUserToAddRows = false;
            this.dgvExportar.AllowUserToDeleteRows = false;
            this.dgvExportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFicha,
            this.Sector,
            this.Corregimiento,
            this.Municipio,
            this.Barrio,
            this.Manzana,
            this.Predio,
            this.Edificio,
            this.UnidadPredial});
            this.dgvExportar.Location = new System.Drawing.Point(12, 187);
            this.dgvExportar.Name = "dgvExportar";
            this.dgvExportar.ReadOnly = true;
            this.dgvExportar.Size = new System.Drawing.Size(764, 157);
            this.dgvExportar.TabIndex = 2;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(472, 367);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(590, 367);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(292, 30);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 5;
            this.lblSector.Text = "Sector:";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(339, 23);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(115, 20);
            this.txtSector.TabIndex = 6;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(15, 65);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 7;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(18, 80);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(55, 20);
            this.txtMunicipio.TabIndex = 8;
            // 
            // lblCorregimiento
            // 
            this.lblCorregimiento.AutoSize = true;
            this.lblCorregimiento.Location = new System.Drawing.Point(94, 65);
            this.lblCorregimiento.Name = "lblCorregimiento";
            this.lblCorregimiento.Size = new System.Drawing.Size(74, 13);
            this.lblCorregimiento.TabIndex = 9;
            this.lblCorregimiento.Text = "Corregimiento:";
            // 
            // txtCorregimiento
            // 
            this.txtCorregimiento.Location = new System.Drawing.Point(107, 80);
            this.txtCorregimiento.Name = "txtCorregimiento";
            this.txtCorregimiento.Size = new System.Drawing.Size(55, 20);
            this.txtCorregimiento.TabIndex = 10;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(191, 65);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 11;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(196, 80);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(55, 20);
            this.txtBarrio.TabIndex = 12;
            // 
            // lblManzana
            // 
            this.lblManzana.AutoSize = true;
            this.lblManzana.Location = new System.Drawing.Point(277, 65);
            this.lblManzana.Name = "lblManzana";
            this.lblManzana.Size = new System.Drawing.Size(54, 13);
            this.lblManzana.TabIndex = 13;
            this.lblManzana.Text = "Manzana:";
            // 
            // txtManzana
            // 
            this.txtManzana.Location = new System.Drawing.Point(285, 80);
            this.txtManzana.Name = "txtManzana";
            this.txtManzana.Size = new System.Drawing.Size(55, 20);
            this.txtManzana.TabIndex = 14;
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(374, 65);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(40, 13);
            this.lblPredio.TabIndex = 15;
            this.lblPredio.Text = "Predio:";
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(374, 80);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(55, 20);
            this.txtPredio.TabIndex = 16;
            // 
            // txtUnidadPredial
            // 
            this.txtUnidadPredial.Location = new System.Drawing.Point(554, 80);
            this.txtUnidadPredial.Name = "txtUnidadPredial";
            this.txtUnidadPredial.Size = new System.Drawing.Size(55, 20);
            this.txtUnidadPredial.TabIndex = 24;
            // 
            // lblUnidadPredial
            // 
            this.lblUnidadPredial.AutoSize = true;
            this.lblUnidadPredial.Location = new System.Drawing.Point(539, 65);
            this.lblUnidadPredial.Name = "lblUnidadPredial";
            this.lblUnidadPredial.Size = new System.Drawing.Size(73, 13);
            this.lblUnidadPredial.TabIndex = 26;
            this.lblUnidadPredial.Text = "UnidadPredial";
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(454, 80);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(55, 20);
            this.txtEdificio.TabIndex = 23;
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Location = new System.Drawing.Point(468, 65);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(41, 13);
            this.lblEdificio.TabIndex = 25;
            this.lblEdificio.Text = "Edificio";
            // 
            // NumeroFicha
            // 
            this.NumeroFicha.DataPropertyName = "strNumeroFicha";
            this.NumeroFicha.HeaderText = "Numero Ficha ";
            this.NumeroFicha.Name = "NumeroFicha";
            this.NumeroFicha.ReadOnly = true;
            this.NumeroFicha.Width = 110;
            // 
            // Sector
            // 
            this.Sector.DataPropertyName = "strSector";
            this.Sector.HeaderText = "Sector ";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 75;
            // 
            // Corregimiento
            // 
            this.Corregimiento.DataPropertyName = "strCorregimiento";
            this.Corregimiento.HeaderText = "Corregimiento";
            this.Corregimiento.Name = "Corregimiento";
            this.Corregimiento.ReadOnly = true;
            this.Corregimiento.Width = 80;
            // 
            // Municipio
            // 
            this.Municipio.DataPropertyName = "strMunicipio";
            this.Municipio.HeaderText = "Municipio ";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.Width = 75;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "strBarrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 75;
            // 
            // Manzana
            // 
            this.Manzana.DataPropertyName = "strManzana";
            this.Manzana.HeaderText = "Manzana o Vereda ";
            this.Manzana.Name = "Manzana";
            this.Manzana.ReadOnly = true;
            this.Manzana.Width = 75;
            // 
            // Predio
            // 
            this.Predio.DataPropertyName = "strPredio";
            this.Predio.HeaderText = "Predio";
            this.Predio.Name = "Predio";
            this.Predio.ReadOnly = true;
            this.Predio.Width = 80;
            // 
            // Edificio
            // 
            this.Edificio.DataPropertyName = "strEdificio";
            this.Edificio.HeaderText = "Edificio";
            this.Edificio.Name = "Edificio";
            this.Edificio.ReadOnly = true;
            this.Edificio.Width = 75;
            // 
            // UnidadPredial
            // 
            this.UnidadPredial.DataPropertyName = "strUnidadPredial";
            this.UnidadPredial.HeaderText = "Unidad Predial ";
            this.UnidadPredial.Name = "UnidadPredial";
            this.UnidadPredial.ReadOnly = true;
            this.UnidadPredial.Width = 75;
            // 
            // frmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 421);
            this.Controls.Add(this.txtUnidadPredial);
            this.Controls.Add(this.lblUnidadPredial);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.txtPredio);
            this.Controls.Add(this.lblPredio);
            this.Controls.Add(this.txtManzana);
            this.Controls.Add(this.lblManzana);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtCorregimiento);
            this.Controls.Add(this.lblCorregimiento);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvExportar);
            this.Controls.Add(this.txtNumeroFicha);
            this.Controls.Add(this.lblNumeroFicha);
            this.Name = "frmExportar";
            this.Text = "Exportar";
            this.Load += new System.EventHandler(this.frmExportar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroFicha;
        private System.Windows.Forms.TextBox txtNumeroFicha;
        private System.Windows.Forms.DataGridView dgvExportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblCorregimiento;
        private System.Windows.Forms.TextBox txtCorregimiento;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblManzana;
        private System.Windows.Forms.TextBox txtManzana;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.TextBox txtUnidadPredial;
        private System.Windows.Forms.Label lblUnidadPredial;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corregimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manzana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadPredial;
    }
}