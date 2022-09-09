using MultApps.Server.Core;
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

            lblHoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();

        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {

            var categoria = string.Empty;

            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Você precisa digitar um nome", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpNascimento.Value;
                int idade = (tsQuantidadeDias.Days / 365);
                
                lblResultadoCategoria.Text = Utilidades.MatriculaAluno(idade, categoria).ToString();
            }
        }
    }
}
