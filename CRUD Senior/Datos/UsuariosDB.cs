using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Senior.Modelo;

namespace CRUD_Senior.Datos
{
    class UsuariosDB
    {
        public static bool guardarUsuario(Usuarios e)
        {
            
                Conexion con = new Conexion();
                string sql = "INSERT INTO tb_usuarios VALUES('" + e.Nombres + "','" + e.ApellidoPaterno + "','" + e.ApellidoMaterno + "','" + e.Puesto + "','" + e.Edad + "','" + e.Correo + "','" + e.FechaNacimiento + "')";
                SqlCommand comando = new SqlCommand(sql,con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }else return false;

                con.Desconectar();

        }
        public static Usuarios consultar(string correo)
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM tb_usuarios WHERE correo ='"+correo+"';";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader dr = comando.ExecuteReader();
            Usuarios em = new Usuarios();
            if(dr.Read())
            {
                em.Nombres = dr["nombres"].ToString();
                em.ApellidoPaterno = dr["apellidoPaterno"].ToString();
                em.ApellidoMaterno = dr["apellidoMaterno"].ToString();
                em.Puesto = dr["puesto"].ToString();
                em.Edad = Convert.ToInt32(dr["numeroTelefono"].ToString());
                em.Correo = dr["correo"].ToString();
                em.FechaNacimiento = dr["fechaNacimiento"].ToString();
                return em;

            }
            else
            {
                return null;
            }
        }
        public static bool actualizar(Usuarios e)
        {
                Conexion con = new Conexion();
                string sql = "UPDATE tb_usuarios SET nombres='" + e.Nombres + "',apellidoPaterno='" + e.ApellidoPaterno + "',apellidoMaterno='" + e.ApellidoMaterno + "',puesto='" + e.Puesto + "',numeroTelefono='" + e.Edad + "',fechaNacimiento='" + e.FechaNacimiento + "'  where correo='" + e.Correo + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else { 
                    con.Desconectar();
                    return false;
                }    
        }
        public static bool borrar(string correo)
        {
                Conexion con = new Conexion();
                string sql = "DELETE FROM tb_usuarios where correo='" + correo + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else
                {
                    con.Desconectar();
                    return false;
                }
        }
    }
}
