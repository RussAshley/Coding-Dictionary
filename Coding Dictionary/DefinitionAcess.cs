using System;
using System.Collections.Generic;
using System.DataSQLite;
using System.Text;

namespace Coding_Dictionary
{
    class DefinitionAcess
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DefinitionAcess (string connectionString)
        {
            ConnectionString = connectionString;
        }


        public DefinitionDatabase ReadTermData (string termName)
        {
            DefinitionDatabase result = new DefinitionDatabase(0, "", "", "", "");
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT* FROM Dictionary WHERE Term=@Term ";
                command.Parameters.AddWithValue("@TermName", termName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.ID1 = reader.GetInt32(0);
                        result.Term1 = reader.GetString(1);
                        result.Image1 = reader.GetString(2);
                        result.URL1 = reader.GetString(3);
                     }   
                }
        }
            return result;
    }


}
