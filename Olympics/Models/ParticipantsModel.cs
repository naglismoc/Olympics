using Olympics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Models
{
    public class ParticipantsModel
    {
        //public ParticipantsModel(ParticipantsService _participants)
        //{
        //    Athletes = _participants.AllAthletes();
        //    Countries = countries;
        //    Sports = sports;
        //}

        public List<AthleteModel> Athletes { get; set; }
        public List<CountryModel> Countries { get; set; }
        public List<SportModel> Sports { get; set; }
        public SortFilterModel SortFilter { get; set; }

    }
}
