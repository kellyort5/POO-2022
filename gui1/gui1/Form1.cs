using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola " + txtNombre.Text + "!";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSaludo.Text = "Escribiendo...";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(nubEdad.Value);

            if (edad >= 18)
            {
                MessageBox.Show("Usted es mayor de edad!", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usted es menor de edad!", "POO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}