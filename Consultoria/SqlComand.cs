using System;
using System.Data.SqlClient;

namespace Consultoria
{
    internal class SqlComand
    {
        private string insertar;
        private SqlConnection sqlConnection;

        public SqlComand(string insertar, SqlConnection sqlConnection)
        {
            this.insertar = insertar;
            this.sqlConnection = sqlConnection;
        }

        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}