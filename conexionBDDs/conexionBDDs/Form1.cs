using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexionBDDs.Properties;

namespace conexionBDDs
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            //esto enlazaba con un texbox pero se sustituyo por un dataGriView
             /*txtcategoria.Clear();
             List<categoria> lista = categoriaDAO.ObetenerCategorias();
            foreach (categoria cat in lista)
            {
                txtcategoria.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
                txtcategoria.AppendText( cat.Description + Environment.NewLine);
            }*/
            dgvcategorias.DataSource = null;
            dgvcategorias.DataSource = categoriaDAO.ObetenerCategorias();
        }
        private void btnCategoriaid_Click(object sender, EventArgs e)
        {
            txtnoparametros.Clear();
            int id = Convert.ToInt32(nudCategoriaid.Text);
            categoria cat = categoriaDAO.FiltrarID(id);
            
            txtnoparametros.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
            txtnoparametros.AppendText( cat.Description + Environment.NewLine);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbname.DataSource = null;
            cmbname.ValueMember = "CategoryID";
            cmbname.DisplayMember = "CategoryName";
            cmbname.DataSource = categoriaDAO.ObetenerCategorias();
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            txtnombres.Clear();
            string nombre = cmbname.Text;
            categoria cat = categoriaDAO.FiltrarName(nombre);
            
            txtnombres.AppendText(cat.CategoryID + ": " + cat.CategoryName + " - ");
            txtnombres.AppendText(cat.Description + Environment.NewLine);   
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string descripcion = txtdescrip.Text;

            if (nombre.Length > 0 && descripcion.Length > 0)
            {
                if (categoriaDAO.Agregarcat(nombre,descripcion ))
                {
                    MessageBox.Show("Categoria agregada exitosamente", "POO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    txtnombre.Clear();
                    txtdescrip.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR! Pruebe mas tarde", "POO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
                }
            }
            else
            {
                
                MessageBox.Show("ERROR! los campos estas vacios", "POO", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            
        }
    }
}
    