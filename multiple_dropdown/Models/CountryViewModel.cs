using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multiple_dropdown.Models
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}