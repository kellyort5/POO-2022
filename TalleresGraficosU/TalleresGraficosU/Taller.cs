using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalleresGraficosU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCabeza.BackColor = Color.FromArgb(112, 188, 68);
        }
        private void btnEncuadernado_Click(object sender, EventArgs e)
        {
            using (frnEncuadernado ventana = new frnEncuadernado())
           {
               DialogResult resultado = ventana.ShowDialog();

               if (resultado == DialogResult.OK)
               {
                   Encuadernado datoDevuelto = ventana.detalle;
                   
                   txtCarrito.AppendText("***Encuadernado encargado***"+Environment.NewLine);
                   txtCarrito.AppendText("Pegado: "+datoDevuelto.pegado+Environment.NewLine);
                   txtCarrito.AppendText("Empastado: "+datoDevuelto.empastado+Environment.NewLine);
                   txtCarrito.AppendText(Environment.NewLine);
                   MessageBox.Show("Encargado con exito", "Talleres graficos UCA", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
               }
           }
        }
        private void btnbarniz_Click(object sender, EventArgs e)
        {
            using (barniz puerta = new barniz())
            {
                DialogResult fin = puerta.ShowDialog();

                if (fin == DialogResult.OK)
                {
                    Barnizz datoDeb = puerta.cosa;
                    
                    txtCarrito.AppendText("***Barniz encargado***"+Environment.NewLine);
                    txtCarrito.AppendText("Plastificado: "+datoDeb.plastificado+Environment.NewLine);
                    txtCarrito.AppendText("Barniz: "+datoDeb.barnizado+Environment.NewLine);
                    txtCarrito.AppendText(Environment.NewLine);
                    MessageBox.Show("Encargado con exito!", "Talleres Graficos UCA", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        private void btnPlegado_Click(object sender, EventArgs e)
        {
            using (plegado coso = new plegado())
            {
                DialogResult x = coso.ShowDialog();

                if (x == DialogResult.OK)
                {
                    plegados datDeb = coso.equis;
                    
                    txtCarrito.AppendText("***Plegado encargado***"+Environment.NewLine);
                    txtCarrito.AppendText("Acabado: "+datDeb.acabados+Environment.NewLine);
                    txtCarrito.AppendText(Environment.NewLine);
                    MessageBox.Show("Encargado con exito!", "Talleres Graficos UCA", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}