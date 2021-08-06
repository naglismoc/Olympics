using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Models
{
    public class SortFilterModel
    {
        public string sortBY { get; set; }
        public string filterByCountry { get; set; } //paduodam šalies Id
        public string filterBySport { get; set; } //paduodam sporto id
        public bool filterByIsTeamActivity { get; set; } //filtruosim pagal sporto parametrą
    }
}
