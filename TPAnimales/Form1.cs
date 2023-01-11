using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIbliotecaAnimales.Entidades;

namespace TPAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(10, 1, 200, true);

            MessageBox.Show(leon.ImprimirPropiedades() + "\n" + "¿Qué come?: " + leon.ImprimirComida());
        }

        private void btnCrearConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(2, 0.30, 3, "marrón");

            MessageBox.Show(conejo.ImprimirPropiedades() + "\n" + "¿Qué come?: " + conejo.ImprimirComida());
        }

        private void btnCrearLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(1, 0.20, 0.35, true);

            MessageBox.Show(loro.ImprimirPropiedades() + "\n" + "¿Qué come?: " + loro.ImprimirComida());
        }
    }
}
