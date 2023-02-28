using Npgsql;
using System.Collections.Generic;



namespace Calculadora.Utils
{
    public static class SumOperationHelper
    {
        public static IEnumerable<object[]> GetAdditionData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=Control123$;Database=operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"AdditionData\"";

                var npgsqlCommand = new NpgsqlCommand(query, connection);
                
                // Here the command is Executed
                var dataReader = npgsqlCommand.ExecuteReader();

                // Here is read the columns 
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];

                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }
                return tableData;
            }
        }
    }
}
