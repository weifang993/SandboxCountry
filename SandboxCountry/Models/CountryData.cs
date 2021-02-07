using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxCountry.Models
{
    public class CountryData
    {
        public int Id { get; set; }

        [DisplayName("Name (English)")]
        public string CountryName_E { get; set; }

        [DisplayName("Name (French)")]
        public string CountryName_F { get; set; }
        
        [DisplayName("Country Code")]
        public string CountryCode_Short { get; set; }
        
        [DisplayName("Country Code (Long)")]
        public string CountryCode_Long { get; set; }

    }
}
