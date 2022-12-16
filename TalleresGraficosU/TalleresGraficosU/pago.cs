using System;
using System.Windows.Forms;

namespace TalleresGraficosU
{
    public partial class pago : Form
    {
        public pagoss cosa { get; set; }
        
        public pago()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string pagoss = radtarjeta.Checked ? "Efectivo" : "Targeta";

        }
    }
}