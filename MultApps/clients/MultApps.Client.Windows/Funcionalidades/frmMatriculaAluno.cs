using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
        }

        private void txtUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " + "NASCIMENTO com 4 dígitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAnoNascimento.Focus();
            }
        }

        private void txtAnoNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txtUltimoAniversario) <= Convert.ToInt32(txtAnoNascimento))
                {
                    MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO " + "deve ser superior ao do nascimento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); e.Cancel = true;
                }             
        }
    }
}
