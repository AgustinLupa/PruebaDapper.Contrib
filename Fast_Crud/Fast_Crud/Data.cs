using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace Fast_Crud
{
    public class Data
    {
        string? connect = "Server=localhost;Database=test;user=root;password=;";
        public List<UserDTO> GetUsers()
        {
            using (IDbConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    //var mysql = @"SELECT * FROM users WHERE((state = 1) and ((name = @Name) and (password = @Password)))";
                    //result = connection.Query<User>(mysql, user).FirstOrDefault();
                    var result = connection.GetAll<UserDTO>().ToList();
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return new List<UserDTO>();
                }
            }
        }

        public dynamic Insert(UserDTO user)
        {
            using (IDbConnection connection = new MySqlConnection(connect))
            {
                try
                {
                    connection.Open();
                    //var mysql = @"SELECT * FROM users WHERE((state = 1) and ((name = @Name) and (password = @Password)))";
                    //result = connection.Query<User>(mysql, user).FirstOrDefault();
                    var result = connection.Insert(user);
                    connection.Close();
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

    }
}
