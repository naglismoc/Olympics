using Olympics.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Services
{

    public class ParticipantsService
    {
        private AthleteDBService _athleteDBS;
        private CountryDBService _countryDBS;
        private SportDBService _sportDBS;
        private SqlConnection _connection;

        public ParticipantsService(AthleteDBService athleteDBS, CountryDBService countryDBS, SportDBService sportDBS, SqlConnection connection)
        {
            _athleteDBS = athleteDBS;
            _countryDBS = countryDBS;
            _sportDBS = sportDBS;
            _connection = connection;
        }
        public ParticipantsModel All()
        {
            ParticipantsModel Participants = new()
            {
                Athletes = _athleteDBS.All(),
                //Countries = _countryDBS.All(), //reik padaryti countries duombaze
                //Sports = _sportDBS.All() //reik padaryti sports duombaze
                Countries = null,
                Sports = null,
                SortFilter = null
            };
            return Participants;
        }
        public ParticipantsModel New()
        {
            List<AthleteModel> List = new();
            List.Add(new AthleteModel());

            ParticipantsModel Participants = new()
            {
               
                Athletes = List,
                //Countries = _countryDBS.All(),
                //Sports = _sportDBS.All()
                Countries = null,
                Sports = null,
                SortFilter = null
            };
            return Participants;
        }
        public void SaveAthlete(ParticipantsModel participants)
        {
            _athleteDBS.Save(participants.Athletes[0]);
        }

    }
}
