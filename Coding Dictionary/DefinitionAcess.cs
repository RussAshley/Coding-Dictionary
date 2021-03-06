using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;

using System.Text;

namespace Coding_Dictionary
{
    class DefinitionAcess
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DefinitionAcess(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public DefinitionDatabase ReadTermData(string termName)
        {
            DefinitionDatabase result = new DefinitionDatabase(0, "", "", "", "");
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT* FROM Dictionary WHERE Term=@TermName ";
                command.Parameters.AddWithValue("@TermName", termName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.ID1 = reader.GetInt32(0);
                        result.Term1 = reader.GetString(1);
                        result.Definition1 = reader.GetString(2);
                        result.Image1 = reader.GetString(3);
                        result.URL1 = reader.GetString(4);
                    }
                }
            }
            return result;
        }

        public void ModifyTerm(DefinitionDatabase termToUpdate)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Dictionary SET Term = @term, Definition = @defintion, Image= @image, URL = @URL WHERE ID = @id";

                command.Parameters.AddWithValue("@term", termToUpdate.Term1);
                command.Parameters.AddWithValue("@defintion", termToUpdate.Definition1);
                command.Parameters.AddWithValue("@image", termToUpdate.Image1);
                command.Parameters.AddWithValue("@URL", termToUpdate.URL1);
                command.Parameters.AddWithValue("@id", termToUpdate.ID1);

                try
                {
                    int count = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }

        }

        //Create
        public void CreateTerm(DefinitionDatabase newDefinitionDatabase)
        {
            //Adds a new term to the db
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Dictionary (term, defintion, URL) VALUES ( @term, @defintion, @URL))";

                command.Parameters.AddWithValue("@term", newDefinitionDatabase.Term1);
                command.Parameters.AddWithValue("@definitionl", newDefinitionDatabase.Definition1);               
                command.Parameters.AddWithValue("@URL", newDefinitionDatabase.URL1);

                try
                {
                    int count = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }
        }




    }



}


  


