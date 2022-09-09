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
    public partial class frmPesoIdeal : Form
    {
        public frmPesoIdeal()
        {
            InitializeComponent();
        }

        public void btnEnviarAltura_Click(object sender, EventArgs e)
        {

            var sexo = string.Empty;
            double altura = double.Parse(txtAltura.Text);

            if (rbnMasculino.Checked == true)
            {
                sexo = "Masculino";
            }
            else if (rbnFeminino.Checked == true)
            {
                sexo = "Feminino";
            }

            lblPesoIdeal.Text = Utilidades.SetPesoIdeal(sexo, altura).ToString("N");    //para chamar a função é necessário digitar seu nome (Utilidade) e o metodo desejado (SetPesoIdeal)

        }
    }
}
