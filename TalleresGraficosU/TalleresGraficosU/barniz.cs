using System;
using System.Windows.Forms;

namespace TalleresGraficosU
{
    public partial class barniz : Form
    {
        public Barnizz cosa { get; set; }
        
        public barniz()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string plastificado =
                radplasB.Checked ? "Brillante" : "Mate";
            string barnizado = radbrillante.Checked ? "Brillante" : "Mate";

            cosa = new Barnizz(plastificado, barnizado);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}