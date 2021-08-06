
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Olympics.Models;

namespace Olympics.Services
{
    public class AthleteDBService
    {

        private SqlConnection _connection;

        public AthleteDBService(SqlConnection connection)
        {


            _connection = connection;
        }
        public List<AthleteModel> All()
        {
            _connection.Open();
            using var command = new SqlCommand("SELECT * FROM dbo.athletes;", _connection);
            using var reader = command.ExecuteReader();
            List<AthleteModel> students = new List<AthleteModel>();
            while (reader.Read())
            {
                AthleteModel b = new AthleteModel()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    Country = reader.GetString(3)


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
        public void Save(AthleteModel athlete)
        {
            _connection.Open();

            string insertText = $"insert into dbo.athletes (name,surname,country) values('{athlete.Name}','{athlete.Surname}','{athlete.Country}'); ";

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
