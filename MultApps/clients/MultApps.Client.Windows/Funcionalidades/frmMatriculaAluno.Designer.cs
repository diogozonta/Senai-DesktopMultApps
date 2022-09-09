namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultadoCategoria = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblHoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:\r\n";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnoNascimento.Location = new System.Drawing.Point(12, 77);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(117, 21);
            this.lblAnoNascimento.TabIndex = 2;
            this.lblAnoNascimento.Text = "Ano nascimento:";
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(12, 127);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(132, 36);
            this.btnIdentificarCategoria.TabIndex = 6;
            this.btnIdentificarCategoria.Text = "Identificar categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(150, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // lblResultadoCategoria
            // 
            this.lblResultadoCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblResultadoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoCategoria.Location = new System.Drawing.Point(229, 136);
            this.lblResultadoCategoria.Name = "lblResultadoCategoria";
            this.lblResultadoCategoria.Size = new System.Drawing.Size(178, 27);
            this.lblResultadoCategoria.TabIndex = 8;
            this.lblResultadoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNascimento.Location = new System.Drawing.Point(135, 77);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(107, 23);
            this.dtpNascimento.TabIndex = 9;
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoje.Location = new System.Drawing.Point(257, 83);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(0, 19);
            this.lblHoje.TabIndex = 10;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 179);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblResultadoCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label lblAnoNascimento;
        private Button btnIdentificarCategoria;
        private Label label4;
        private Label lblResultadoCategoria;
        private DateTimePicker dtpNascimento;
        private Label lblHoje;
    }
}