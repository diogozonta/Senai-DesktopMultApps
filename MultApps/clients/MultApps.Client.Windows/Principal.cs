using MultApps.Client.Windows.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAbrirFormPesoIdeal_Click(object sender, EventArgs e)
        {
            var form = new frmPesoIdeal();
            form.Show();
        }

        private void btnAbrirFormMatriculaAluno_Click(object sender, EventArgs e)
        {
            var form = new frmMatriculaAluno();
            form.Show();
        }

        private void btnAbrirFormReajusteSalarial_Click(object sender, EventArgs e)
        {
            var form = new frmReajusteSalarial();
            form.Show();
;       }
    }
}
