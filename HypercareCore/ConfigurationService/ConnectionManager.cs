﻿using System.Data;
using System.Data.SqlClient;

namespace ConfigurationService
{
    public static class ConnectionManager
    {
        public static IDbConnection GetInlineConnectionString()
        {
            string connectionString = ConfigSettings.GetInlineConnectionString();
            return new SqlConnection(connectionString);
        }

        public static IDbConnection GetSPConnectionString()
        {
            string connectionString = ConfigSettings.GetSPConnectionString();
            return new SqlConnection(connectionString);
        }

        public static IDbConnection GetLocalConnectionString()
        {
            string connectionString = ConfigSettings.GetStorageConnection();
            return new SqlConnection(connectionString);
        }
    }
}
