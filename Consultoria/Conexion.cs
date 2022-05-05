using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Consultoria
{
    internal class Conexion
    {
        
            public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("SERVER=EDROCK\\SERVIDORTESI; DATABASE=CONSULTORIA2;integrated security=true");
            con.Open();
            return con;

        }
    }
}
