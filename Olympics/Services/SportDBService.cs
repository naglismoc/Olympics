
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Olympics.Models;

namespace Olympics.Services
{
    public class SportDBService
    {

        private SqlConnection _connection;

        public SportDBService(SqlConnection connection)
        {


            _connection = connection;
        }
        public List<SportModel> All()
        {
            _connection.Open();
            using var command = new SqlCommand("SELECT * FROM dbo.sports;", _connection);
            using var reader = command.ExecuteReader();
            List<SportModel> students = new List<SportModel>();
            while (reader.Read())
            {
                SportModel b = new SportModel()
                {
                    Id = reader.GetInt32(0),
                    Type = reader.GetString(1),
                    TeamActivity = reader.GetBoolean(2),


                };
                students.Add(b);
            }
            _connection.Close();

            return students;
        }

        public SportModel Find(int Id)
        {
            return new();
        }
        public void Save(SportModel sport)
        {
            _connection.Open();

            string insertText = $"insert into dbo.sports (type,team_activity) values('{sport.Type}','{sport.TeamActivity})'; ";

            SqlCommand command = new SqlCommand(insertText, _connection);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(SportModel sport)
        {

        }
        public void Delete(SportModel sport)
        {

        }
    }
}
