using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    public static class SubstractOperationHelper
    {
        public static IEnumerable<object[]> GetSubstractData()
        {
            var cs = "Host=localhost;Username=postgres;Password=Control123$;Database=operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"SubstractData\"";

                var npgsqlCommand = new NpgsqlCommand(query, connection);

                // here the command is  Executed
                var dataReader = npgsqlCommand.ExecuteReader();

                // here is read the columns
                var fieldCound = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCound];

                    int instaces = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }
                return tableData;
            }
        }
    }
}
