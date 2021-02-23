using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public string CountryCode_Short { get; set; }
        
        [DisplayName("Country Code (Long)")]
        public string CountryCode_Long { get; set; }

    }
}
