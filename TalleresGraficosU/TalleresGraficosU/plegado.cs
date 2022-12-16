using System;
using System.Windows.Forms;

namespace TalleresGraficosU
{
    public partial class plegado : Form
    {
        public plegados equis { get; set; }
        
        public plegado()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string acabados = radDiptico.Checked ? "Diptico" :
                radtriptico.Checked ? "Triptico" :
                radcuadriptico.Checked ? "Cuadriptico" : "Acordeon";
            equis = new plegados(acabados);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}