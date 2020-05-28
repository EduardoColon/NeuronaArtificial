namespace ProyectoNeuronaArtificial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.NumericUpDown();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dgvPesos = new System.Windows.Forms.DataGridView();
            this.asdas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactorAjuste = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUmbral = new System.Windows.Forms.NumericUpDown();
            this.bCalcular = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bAjustar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorAjuste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUmbral)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar peso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.DecimalPlaces = 2;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtPeso.Location = new System.Drawing.Point(191, 18);
            this.txtPeso.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPeso.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(132, 37);
            this.txtPeso.TabIndex = 1;
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAgregar.Location = new System.Drawing.Point(363, 18);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(149, 56);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPesos
            // 
            this.dgvPesos.AllowUserToAddRows = false;
            this.dgvPesos.AllowUserToOrderColumns = true;
            this.dgvPesos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvPesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asdas,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesos.Location = new System.Drawing.Point(21, 94);
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.RowHeadersWidth = 62;
            this.dgvPesos.RowTemplate.Height = 28;
            this.dgvPesos.Size = new System.Drawing.Size(491, 314);
            this.dgvPesos.TabIndex = 3;
            // 
            // asdas
            // 
            this.asdas.HeaderText = "Subindice ";
            this.asdas.MinimumWidth = 8;
            this.asdas.Name = "asdas";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Peso";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvPesos);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.bAgregar);
            this.panel1.Location = new System.Drawing.Point(76, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 438);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFactorAjuste);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUmbral);
            this.panel2.Location = new System.Drawing.Point(76, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 218);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(88, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Factor ajuste:";
            // 
            // txtFactorAjuste
            // 
            this.txtFactorAjuste.DecimalPlaces = 2;
            this.txtFactorAjuste.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtFactorAjuste.Location = new System.Drawing.Point(306, 116);
            this.txtFactorAjuste.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtFactorAjuste.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.txtFactorAjuste.Name = "txtFactorAjuste";
            this.txtFactorAjuste.Size = new System.Drawing.Size(132, 37);
            this.txtFactorAjuste.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor umbral:";
            // 
            // txtUmbral
            // 
            this.txtUmbral.DecimalPlaces = 2;
            this.txtUmbral.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtUmbral.Location = new System.Drawing.Point(306, 58);
            this.txtUmbral.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtUmbral.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.txtUmbral.Name = "txtUmbral";
            this.txtUmbral.Size = new System.Drawing.Size(132, 37);
            this.txtUmbral.TabIndex = 3;
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bCalcular.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.bCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCalcular.Location = new System.Drawing.Point(241, 866);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(193, 76);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvMatriz);
            this.panel3.Location = new System.Drawing.Point(657, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 693);
            this.panel3.TabIndex = 7;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvMatriz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatriz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriz.Location = new System.Drawing.Point(19, 19);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            this.dgvMatriz.RowHeadersVisible = false;
            this.dgvMatriz.RowHeadersWidth = 40;
            this.dgvMatriz.RowTemplate.Height = 28;
            this.dgvMatriz.Size = new System.Drawing.Size(1064, 657);
            this.dgvMatriz.TabIndex = 0;
            // 
            // bNuevo
            // 
            this.bNuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bNuevo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bNuevo.Location = new System.Drawing.Point(1676, 21);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(149, 56);
            this.bNuevo.TabIndex = 8;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = false;
            this.bNuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // bAjustar
            // 
            this.bAjustar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bAjustar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.bAjustar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAjustar.Location = new System.Drawing.Point(1102, 866);
            this.bAjustar.Name = "bAjustar";
            this.bAjustar.Size = new System.Drawing.Size(209, 76);
            this.bAjustar.TabIndex = 9;
            this.bAjustar.Text = "Ajustar";
            this.bAjustar.UseVisualStyleBackColor = false;
            this.bAjustar.Click += new System.EventHandler(this.bAjustar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(909, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 60);
            this.label4.TabIndex = 10;
            this.label4.Text = "Neurona artificial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1576, 879);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Eduardo Colón";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1632, 912);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jaime Noj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1530, 942);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Anderson Sandoval";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1008);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAjustar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neurona Artificial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorAjuste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUmbral)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtPeso;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridView dgvPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtUmbral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtFactorAjuste;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bAjustar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

