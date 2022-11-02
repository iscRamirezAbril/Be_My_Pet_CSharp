using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeMyPet
{
    public class Client
    {
        public string clientUsername { get; set; }
        public string clientPassword { get; set; }
        public string clientFirsName { get; set; }
        public string clientLastName { get; set; }
        public int clientSuperuser { get; set; }
        public DateTime clientLastLogin { get; set; }
        public DateTime clientDateJoined { get; set; }

        public bool ValidUser(string Username)
        {
            string Consulta = @"SELECT COUNT(*) FROM Client WHERE clientUsername = @clientUsername ; ";
            using (SqlConnection Conn = ConnectionDB.StartConn())
            {
                SqlCommand cmd = new SqlCommand(Consulta, Conn);
                cmd.Parameters.AddWithValue("@clientUsername ", Username);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
              
                return Count == 0;
            }
        }

        public bool Login(string Username, string Password)
        {
            string Consulta = @"SELECT COUNT(*) FROM Client WHERE 
            clientUsername = @clientUsername 
            AND 
            (CONVERT(VARCHAR(max),DECRYPTBYPASSPHRASE('password',clientPassword))) = @clientPassword; ";
            using (SqlConnection Conn = ConnectionDB.StartConn())
            {
                SqlCommand cmd = new SqlCommand(Consulta, Conn);
                cmd.Parameters.AddWithValue("@clientUsername ", Username);
                cmd.Parameters.AddWithValue("@clientPassword ", Password);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                Conn.Close();
                return Count == 0;
            }
        }
    }

    public class ConnectionDB
    {
        public static SqlConnection StartConn()
        {
            // Configuración de los parámetros para conectar con la base de datos.
            string[] Config = { "Data Source = DESKTOP-HF5VLA2\\DB;",
            /*                 */"Initial Catalog=MyPet;",
            /*                 */"Integrated Security=True"};
            string Connection = Config[0] + Config[1] + Config[2];
            SqlConnection Conn = new SqlConnection(Connection);
            Conn.Open();
            return Conn;
        }
    }

}
