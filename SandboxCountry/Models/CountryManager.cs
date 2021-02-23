using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxCountry.Models
{
    public class CountryManager 
    {
        private readonly string ConnectionString;

        public CountryManager(string connection)
        {
            ConnectionString = connection;
        }

        public CountryData GetCountry(string countryCode)
        {
            var result = new CountryData();

            using (var conn = new NpgsqlConnection(ConnectionString)) {
                conn.Open();
                using (var command = new NpgsqlCommand("Select * from country where country_code_short='" + countryCode + "'", conn))
                using (var reader = command.ExecuteReader()) { 
                    while (reader.Read()) {
                        Console.Write("\tcontry {0}: {1}\n", reader.GetValue(0), reader.GetValue(1));

                        result.Id = reader.GetInt32(0);
                        result.CountryName_E = reader.GetString(1);
                        result.CountryName_F = reader.GetString(2);
                        result.CountryCode_Short = reader.GetString(3);
                        result.CountryCode_Long = reader.GetString(4);
                    }                
                    reader.Close();
                }
            }

            return result;
        }
    }
}
