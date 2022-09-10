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
    public partial class frmReajusteSalarial : Form
    {
        public frmReajusteSalarial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            
            var rbnTrueTurno = rbnTurno.Checked;    //pegando o valor booleano do rbnTurno
            var rbnTrueCategoria = rbnCategoria.Checked;    //pegando o valor booleano do rbnCategoria

            var horasTrabalhadas = double.Parse(txtHorasTrabalhadas.Text);  
            var valorSalarioMinimo = double.Parse(txtSalarioMinimo.Text);

            string textoTurno = rbnTurno.Text;
            string textoCategoria = rbnCategoria.Text;
            
        }
    }
}
