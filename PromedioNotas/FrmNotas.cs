using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Promedio objPro = new Promedio();

            objPro.Nombre = txtNombre.Text;
            objPro.Nota1 = int.Parse(txtNota1.Text);
            objPro.Nota2 = int.Parse(txtNota2.Text);
            objPro.Nota3 = int.Parse(txtNota3.Text);
            objPro.Nota4 = int.Parse(txtNota4.Text);


            lblNotaBaja.Text = objPro.NotaBaja().ToString("0.00");
            lblPromedio.Text = objPro.promedio().ToString("0.00");
            lblCondicion.Text = objPro.condicion();





        }
    }
}
