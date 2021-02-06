using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxCountry.Models
{
    public class CountryManager
    {
        public CountryData GetCountry(string code)
        {
            if (code == "CA")
                return new CountryData {Code = "CA", Name = "Canada"};
            else
                return null;
        }
    }
}
