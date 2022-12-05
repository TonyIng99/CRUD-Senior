using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_Senior.Datos
{
    class Conexion
    {
        SqlConnection con;
        public Conexion(){
            con = new SqlConnection("Server=localhost;Database=db_usuarios;integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }catch(Exception e)
            {
                return null;
            }
            
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
