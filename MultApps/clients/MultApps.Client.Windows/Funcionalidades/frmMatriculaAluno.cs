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
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Você precisa digitar um nome", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpNascimento.Value;

                int idade = (tsQuantidadeDias.Days / 365);

                if (idade > 17)
                {
                    lblResultadoCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblResultadoCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblResultadoCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblResultadoCategoria.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblResultadoCategoria.Text = "Infantil A";
                }
                else
                {
                    lblResultadoCategoria.Text = "Não existe categoria";
                }
            }
        }
    }
}
