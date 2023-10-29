using Dapper;
using Hackathon.API.DTOs;
using Hackathon.API.Infrastructure;
using System.Data;

namespace Hackathon.API.Entities
{
    public class DailyChallenges
    {
        public int IdChallenge { get; set; }
        public string challengeDescription { get; set; }
        
        public void insertUserChallenge(int IdUser, int IdChallenge)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", IdUser);
            parameters.Add("challengeId", IdChallenge);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("insertUserChallenge", parameters, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<string> getDailyChallenge()
        {
            var parameters = new DynamicParameters();
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            var result =  connection.Query<string>("GetDailyChallenge", parameters, commandType: CommandType.StoredProcedure);
            
            return result;

        }
        public int GetDailyChallengeIdByName(string challengeDescription)
        {
            var parameters = new DynamicParameters();
            parameters.Add("challengeDescription", challengeDescription);
            parameters.Add("challengeId", DbType.Int32, direction: ParameterDirection.Output);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("GetDailyChallengeIdByName", parameters, commandType: CommandType.StoredProcedure);
            int challengeId = parameters.Get<int>("challengeId");
            return challengeId;
        }
    }
}
