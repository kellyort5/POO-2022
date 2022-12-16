using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using conexionBDDs.Properties;

namespace conexionBDDs
{
    public static class categoriaDAO
    {
        public static categoria FiltrarID(int id)
        {
            categoria cat = new categoria();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT CategoryID, CategoryName, Description FROM Categories where CategoryID = @idbuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idbuscado", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        cat.CategoryName = reader["CategoryName"].ToString();
                        cat.Description = reader["Description"].ToString();

                    }
                }

                connection.Close();
            }
            return cat;
        }
        public static List<categoria> ObetenerCategorias()
        {
            List<categoria> lista = new List<categoria>();
            //1. cadena de conexion
            string cadena = Resources.cadena_conexion;
            //2. conexion a la base de datos
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    //3. configurando nuestra consulta SQL
                    string query = "select CategoryID, CategoryName, Description from Categories order by CategoryName asc";
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    //4.1 abrir la conexion
                    connection.Open();
                    //5. manejo de resultados 
                    using (SqlDataReader reader = command.ExecuteReader( ))
                    {
                        while (reader.Read( ))
                        {
                            categoria cat = new categoria();
                            cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                            cat.CategoryName = reader["CategoryName"].ToString();
                            cat.Description = reader["Description"].ToString();
                            lista.Add(cat);
                        }
                    }
                    //4.3 cerrar la conexion
                    connection.Close();
                }
            }
            return lista;
        }
        public static categoria FiltrarName(string name)
        {
            categoria cat = new categoria();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT CategoryID, CategoryName, Description from Categories where CategoryName = @namebuscando";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscando", name);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cat.CategoryID = Convert.ToInt32(reader["CategoryID"].ToString());
                        cat.CategoryName = reader["CategoryName"].ToString();
                        cat.Description = reader["Description"].ToString();

                    }
                }
                connection.Close();
            }
            return cat;
        }
        /*
        public static void Agregarcat(string name, string description)
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO Categories(CategoryName, Description) VALUES (@nombre, @descripcion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", name);
                command.Parameters.AddWithValue("@descripcion", description);
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }*/
        public static bool Agregarcat(string name, string description)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "INSERT INTO Categories(CategoryName, Description) VALUES (@nombre, @descripcion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", name);
                    command.Parameters.AddWithValue("@descripcion", description);
                
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}

