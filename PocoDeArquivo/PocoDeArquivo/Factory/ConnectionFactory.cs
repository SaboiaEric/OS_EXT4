using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PocoDeArquivo.Model;

namespace PocoDeArquivo.Factory 
{
    public static class ConnectionFactory
    {
        private static SqlConnection _connection;

        #region Open
        public static SqlConnection Open()
        {
            if (_connection.State == ConnectionState.Closed)
               _connection.Open();
            return _connection;
        }
        #endregion

        #region Close
        public static bool Close()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                return true;
            }
            return false;
        }
        #endregion

    }
}
