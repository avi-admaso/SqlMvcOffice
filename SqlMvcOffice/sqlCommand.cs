using System;
using System.Data.SqlClient;

namespace SqlMvcOffice
{
    internal class sqlCommand
    {
        private object query;
        private SqlConnection connection;

        public sqlCommand(object query, SqlConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}