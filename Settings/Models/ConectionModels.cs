using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenialNetApplication.Settings.Models
{
    public  class ConectionModels
    {
        public string DataSource { get; set; }
        public string UserID { get;  set; }           
        public string Password { get;  set; }   
        public string InitialCatalog { get;  set; }

        public ConectionModels(string userID,string password, string initialCatalog)
        {
            DataSource = "GenialApplication";
            UserID = userID;
            Password = password;
            InitialCatalog = initialCatalog;
        }
        public ConectionModels()
        {
            
        }

        public bool IsConnection(string connection)
        {
            //Verificar se o banco de dados existe
            var iscreateBd = EnsureDatabaseExists(connection, DataSource);
            if (iscreateBd)
            {
                try
                {
                    ConectionModels Models = new ConectionModels();
                    Models.DataSource = "GenialApplication";
                    Models.UserID = UserID;
                    Models.Password = Password;
                    Models.InitialCatalog = InitialCatalog;

                    PreferencesDb.SetPreferenceBD(Models);

                    using (var context = new ApplicationDbContext())
                    {
                        // Garantir que o banco de dados seja criado
                        context.Database.EnsureCreated();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                   
                }
              
            }
            return iscreateBd;
        }

        private bool EnsureDatabaseExists(string connectionString, string databaseName)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkDbQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{databaseName}'";
                    using (var command = new SqlCommand(checkDbQuery, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result == null)
                        {
                            //Criação do banco de dados
                            string createDbQuery = $"CREATE DATABASE [{databaseName}]";
                            using (var createCommand = new SqlCommand(createDbQuery, connection))
                            {
                                createCommand.ExecuteNonQuery();

                                Console.WriteLine($"Banco de dados '{databaseName}' criado com sucesso.");
                                return true;
                            }
                        }

                        return true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
           
        }      

    }
}
