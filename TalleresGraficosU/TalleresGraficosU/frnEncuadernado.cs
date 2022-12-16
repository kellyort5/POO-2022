using System;
using System.Windows.Forms;

namespace TalleresGraficosU
{
    public partial class frnEncuadernado : Form
    {
        public Encuadernado detalle { get; set; }
        public frnEncuadernado()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string pegado =
                radHotMelt.Checked ? "Hot Melt" :
                radAnillado.Checked ? "Anillado" : "Engrapado";
            string empastado = radLujo.Checked ? "De lujo" : "Rustica";
            detalle = new Encuadernado(pegado, empastado);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
                this.Close();
        }
    }
}