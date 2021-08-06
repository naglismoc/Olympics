
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Olympics.Models;

namespace Olympics.Services
{
    public class CountryDBService
    {

        private SqlConnection _connection;

        private CountryDBService _countryDBS;

        public CountryDBService(SqlConnection connection, CountryDBService countryDBS)
        {
            _connection = connection;
            _countryDBS = countryDBS;
        }

        public List<CountryModel> All()
        {
            _connection.Open();
            using var command = new SqlCommand("SELECT * FROM dbo.countries;", _connection);
            using var reader = command.ExecuteReader();
            List<CountryModel> students = new List<CountryModel>();
            while (reader.Read())
            {
                CountryModel b = new CountryModel()
                {
                    Id = reader.GetInt32(0),
                    CountryName = reader.GetString(1),
                    IBAN = reader.GetString(2)


                };
                students.Add(b);
            }
            _connection.Close();

            return students;
        }

        public AthleteModel Find(int Id)
        {
            return new();
        }
        public void Save(CountryModel country)
        {
            _connection.Open();

            string insertText = $"insert into dbo.countries (country_name,iban) values('{country.CountryName}','{country.IBAN}'); ";

            SqlCommand command = new SqlCommand(insertText, _connection);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(AthleteModel athlete)
        {

        }
        public void Delete(AthleteModel athlete)
        {

        }
    }
}
