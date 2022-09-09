namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCategoriaCalouro = new System.Windows.Forms.RadioButton();
            this.rdbCategoriaVeterano = new System.Windows.Forms.RadioButton();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTurnoNoturno = new System.Windows.Forms.RadioButton();
            this.rdbTurnoMatutino = new System.Windows.Forms.RadioButton();
            this.rdbTurnoVespertino = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblResultadoSalario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Minímo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Trabalhadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCategoriaCalouro);
            this.groupBox1.Controls.Add(this.rdbCategoriaVeterano);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // rdbCategoriaCalouro
            // 
            this.rdbCategoriaCalouro.AutoSize = true;
            this.rdbCategoriaCalouro.Location = new System.Drawing.Point(140, 24);
            this.rdbCategoriaCalouro.Name = "rdbCategoriaCalouro";
            this.rdbCategoriaCalouro.Size = new System.Drawing.Size(75, 23);
            this.rdbCategoriaCalouro.TabIndex = 5;
            this.rdbCategoriaCalouro.TabStop = true;
            this.rdbCategoriaCalouro.Text = "Calouro";
            this.rdbCategoriaCalouro.UseVisualStyleBackColor = true;
            // 
            // rdbCategoriaVeterano
            // 
            this.rdbCategoriaVeterano.AutoSize = true;
            this.rdbCategoriaVeterano.Location = new System.Drawing.Point(21, 24);
            this.rdbCategoriaVeterano.Name = "rdbCategoriaVeterano";
            this.rdbCategoriaVeterano.Size = new System.Drawing.Size(82, 23);
            this.rdbCategoriaVeterano.TabIndex = 4;
            this.rdbCategoriaVeterano.TabStop = true;
            this.rdbCategoriaVeterano.Text = "Veterano";
            this.rdbCategoriaVeterano.UseVisualStyleBackColor = true;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(155, 20);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(129, 23);
            this.txtSalarioMinimo.TabIndex = 4;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(155, 61);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(129, 23);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTurnoNoturno);
            this.groupBox2.Controls.Add(this.rdbTurnoMatutino);
            this.groupBox2.Controls.Add(this.rdbTurnoVespertino);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // rdbTurnoNoturno
            // 
            this.rdbTurnoNoturno.AutoSize = true;
            this.rdbTurnoNoturno.Location = new System.Drawing.Point(18, 112);
            this.rdbTurnoNoturno.Name = "rdbTurnoNoturno";
            this.rdbTurnoNoturno.Size = new System.Drawing.Size(79, 23);
            this.rdbTurnoNoturno.TabIndex = 8;
            this.rdbTurnoNoturno.TabStop = true;
            this.rdbTurnoNoturno.Text = "Noturno";
            this.rdbTurnoNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbTurnoMatutino
            // 
            this.rdbTurnoMatutino.AutoSize = true;
            this.rdbTurnoMatutino.Location = new System.Drawing.Point(18, 34);
            this.rdbTurnoMatutino.Name = "rdbTurnoMatutino";
            this.rdbTurnoMatutino.Size = new System.Drawing.Size(84, 23);
            this.rdbTurnoMatutino.TabIndex = 7;
            this.rdbTurnoMatutino.TabStop = true;
            this.rdbTurnoMatutino.Text = "Matutino";
            this.rdbTurnoMatutino.UseVisualStyleBackColor = true;
            // 
            // rdbTurnoVespertino
            // 
            this.rdbTurnoVespertino.AutoSize = true;
            this.rdbTurnoVespertino.Location = new System.Drawing.Point(18, 72);
            this.rdbTurnoVespertino.Name = "rdbTurnoVespertino";
            this.rdbTurnoVespertino.Size = new System.Drawing.Size(92, 23);
            this.rdbTurnoVespertino.TabIndex = 6;
            this.rdbTurnoVespertino.TabStop = true;
            this.rdbTurnoVespertino.Text = "Vespertino";
            this.rdbTurnoVespertino.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(25, 174);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(391, 124);
            this.listBox1.TabIndex = 7;
            // 
            // lblResultadoSalario
            // 
            this.lblResultadoSalario.BackColor = System.Drawing.Color.Yellow;
            this.lblResultadoSalario.Location = new System.Drawing.Point(25, 321);
            this.lblResultadoSalario.Name = "lblResultadoSalario";
            this.lblResultadoSalario.Size = new System.Drawing.Size(259, 31);
            this.lblResultadoSalario.TabIndex = 8;
            this.lblResultadoSalario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultadoSalario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmReajusteSalarial";
            this.Text = "frmReajusteSalarial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdbCategoriaCalouro;
        private RadioButton rdbCategoriaVeterano;
        private TextBox txtSalarioMinimo;
        private TextBox txtHorasTrabalhadas;
        private GroupBox groupBox2;
        private RadioButton rdbTurnoNoturno;
        private RadioButton rdbTurnoMatutino;
        private RadioButton rdbTurnoVespertino;
        private ListBox listBox1;
        private Label lblResultadoSalario;
        private Button button1;
        private ToolTip toolTip1;
    }
}