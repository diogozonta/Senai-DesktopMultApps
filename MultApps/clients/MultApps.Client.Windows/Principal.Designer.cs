﻿namespace MultApps.Client.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirFormPesoIdeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormPesoIdeal.BackgroundImage")));
            this.btnAbrirFormPesoIdeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirFormPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormPesoIdeal.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(62, 12);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(245, 78);
            this.btnAbrirFormPesoIdeal.TabIndex = 0;
            this.btnAbrirFormPesoIdeal.Text = "        Peso Ideal";
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = false;
            this.btnAbrirFormPesoIdeal.Click += new System.EventHandler(this.btnAbrirFormPesoIdeal_Click);
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirFormMatriculaAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormMatriculaAluno.BackgroundImage")));
            this.btnAbrirFormMatriculaAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirFormMatriculaAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormMatriculaAluno.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(62, 96);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(245, 78);
            this.btnAbrirFormMatriculaAluno.TabIndex = 1;
            this.btnAbrirFormMatriculaAluno.Text = "Matricula de Aluno";
            this.btnAbrirFormMatriculaAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirFormMatriculaAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormMatriculaAluno.UseVisualStyleBackColor = false;
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.btnAbrirFormMatriculaAluno_Click);
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirFormReajusteSalarial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormReajusteSalarial.BackgroundImage")));
            this.btnAbrirFormReajusteSalarial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirFormReajusteSalarial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormReajusteSalarial.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(62, 180);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(245, 78);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirFormReajusteSalarial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = false;
            this.btnAbrirFormReajusteSalarial.Click += new System.EventHandler(this.btnAbrirFormReajusteSalarial_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(383, 286);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultApps";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormMatriculaAluno;
        private Button btnAbrirFormReajusteSalarial;
    }
}