﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ParkingLib
{
    public class Helper
    {
        //Kết nối CSDL
        public static SqlConnection OpenConnection()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionStringSqlServer"];
            var sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
            }
            return sqlConnection;
        }
    }
}