using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtPeso_Validated(object sender, EventArgs e)
        {

        }

        private void MskbxPeso_Validated(object sender, EventArgs e)
        {
            double peso;
            errorProvider1.SetError(mskbxPeso, "");

            if (!double.TryParse(mskbxPeso.Text, out peso) || (peso<=0))
	{
                MessageBox.Show("Peso Inválido!");
                errorProvider1.SetError(mskbxPeso, "Altura inválido");
                mskbxPeso.Focus();
            }
        }

        private void MskbxAltura_Validated(object sender, EventArgs e)
        {
            double altura;
            errorProvider1.SetError(mskbxAltura, "");

            if (!double.TryParse(mskbxAltura.Text, out altura) || (altura <= 0))
	{
                MessageBox.Show("Altura Inválida!");
                errorProvider2.SetError(mskbxAltura, "Altura inválida");
                mskbxAltura.Focus();
                
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }

    }
}