using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxCountry.Models
{
    public class CountryManager
    {
        public string GetCountry(string code)
        {
            if (code == "CA")
                return "Canada";
            else
                return null;
        }
    }
}
