using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxCountry.Models
{
    public class CountryData
    {
        [DisplayName("Country Code")]
        public string Code { get; set; }

        [DisplayName("Name (English)")]
        public string Name { get; set; }
    }
}
