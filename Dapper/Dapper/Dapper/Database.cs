﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    public class Database
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["NWConnectionString"].ConnectionString;
            }
        }

        public static SqlConnection GetSqlConnection()
        {

            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
        }
    }
}
