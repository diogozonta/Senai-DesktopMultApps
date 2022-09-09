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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnEnviarDados = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultadoCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:\r\n";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 31);
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano último aniversário:\r\n";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(120, 77);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(69, 23);
            this.txtAnoNascimento.TabIndex = 4;
            this.txtAnoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoNascimento_Validating);
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(344, 77);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(64, 23);
            this.txtUltimoAniversario.TabIndex = 5;
            this.txtUltimoAniversario.Enter += new System.EventHandler(this.txtUltimoAniversario_Enter);
            // 
            // btnEnviarDados
            // 
            this.btnEnviarDados.Location = new System.Drawing.Point(12, 127);
            this.btnEnviarDados.Name = "btnEnviarDados";
            this.btnEnviarDados.Size = new System.Drawing.Size(132, 36);
            this.btnEnviarDados.TabIndex = 6;
            this.btnEnviarDados.Text = "Identificar categoria";
            this.btnEnviarDados.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(150, 136);
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
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.lblResultadoCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviarDados);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.label3);
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
        private Label label3;
        private TextBox txtAnoNascimento;
        private TextBox txtUltimoAniversario;
        private Button btnEnviarDados;
        private Label label4;
        private Label lblResultadoCategoria;
    }
}