using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            using (var conn = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand("GetCountryForCode", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@countryCode", countryCode);

                conn.Open();
                var rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result.Id = (int)rdr["id"];
                    result.CountryName_E = (string)rdr["country_name_e"];
                    result.CountryName_F = (string)rdr["country_name_f"];
                    result.CountryCode_Short = (string)rdr["country_code_short"];
                    result.CountryCode_Long = (string)rdr["country_code_long"];
                }
                rdr.Close();

            }

            return result;
        }
    }
}
