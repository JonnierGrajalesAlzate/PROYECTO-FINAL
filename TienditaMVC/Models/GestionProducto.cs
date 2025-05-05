using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TienditaMVC.Models
{
    public class GestionProducto
    {
        private SqlConnection con;

        //Metodo para conectar
        private void conectar(){
            string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            con=new SqlConnection(cadena);
        }

        //Metodo para registrar
        public int registrar(Producto producto)
        {
            conectar();
            SqlCommand comando=new SqlCommand("insert into productos values(@codigo,@descripcion,@precio)",con);
            comando.Parameters.Add("@codigo",SqlDbType.Int);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@precio", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = producto.codigo;
            comando.Parameters["@descripcion"].Value = producto.descripcion;
            comando.Parameters["@precio"].Value = producto.precio;
            con.Open();
            int i=comando.ExecuteNonQuery();
            con.Close();
            return i;
        }//metodo

        //Metodo para listar
        public List<Producto> listarTodos()
        {
            conectar();
            List<Producto> lista=new List<Producto>();
            SqlCommand comando = new SqlCommand("select * from productos", con);
            con.Open();
            SqlDataReader registros= comando.ExecuteReader();
            while (registros.Read()){
                Producto producto = new Producto { 
                    codigo=int.Parse(registros["codigo"].ToString()),
                    descripcion=registros["descripcion"].ToString(),
                    precio = int.Parse(registros["precio"].ToString())
                };
                lista.Add(producto);
            }
            con.Close();
            return lista;
        }//metodo

        //Metodo para buscar un producto
        public Producto buscar(int cod)
        {
            conectar();
            SqlCommand comando = new SqlCommand("select * from productos where codigo=@codigo", con);
            comando.Parameters.Add("@codigo",SqlDbType.Int);
            comando.Parameters["@codigo"].Value= cod;
            con.Open();
            SqlDataReader registros= comando.ExecuteReader();
            Producto producto=new Producto();
            if (registros.Read())
            {
                producto.codigo = int.Parse(registros["codigo"].ToString());
                producto.descripcion = registros["descripcion"].ToString();
                producto.precio = int.Parse(registros["precio"].ToString());
            }
            con.Close();
            return producto;
        }//metodo

        //Metodo para actualizar
        public int actualizar(Producto producto)
        {
            conectar();
            SqlCommand comando = new SqlCommand("update productos set descripcion=@descripcion,precio=@precio where codigo=@codigo", con);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@precio", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = producto.codigo;
            comando.Parameters["@descripcion"].Value = producto.descripcion;
            comando.Parameters["@precio"].Value = producto.precio;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }//metodo

        //metodo para eliminar
        public int eliminar(int codigo)
        {
            conectar();
            SqlCommand comando = new SqlCommand("delete from productos where codigo=@codigo", con);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = codigo;
            con.Open();
            int i=comando.ExecuteNonQuery();
            con.Close();
            return i;
        }//metodo

    }//clase
}