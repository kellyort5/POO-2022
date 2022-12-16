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
using AeropuertoBDDs_POO.Properties;

namespace AeropuertoBDDs_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btmPasajeros_Click(object sender, EventArgs e)
        {
            string cadena = Resources.cadena_conexion;
            
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select id,nombre, email from PASAJERO";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open( );
                using (SqlDataReader reader = command.ExecuteReader( ))
                {
                    while (reader.Read())
                    {     
                        int id = Convert.ToInt32(reader["id"].ToString( ));
                        string nombre = reader["nombre"].ToString( );
                        string email = reader["email"].ToString( );
                        
                        txtPasajeros.AppendText(id + ": " + nombre + " - ");
                        txtPasajeros.AppendText(email + Environment.NewLine);
                    }
                }
                connection.Close( );
            }
        }
    }
}