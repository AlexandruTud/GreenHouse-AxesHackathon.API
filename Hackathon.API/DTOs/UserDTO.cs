using Dapper;
using Hackathon.API.Entities;
using Hackathon.API.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Data;
using System.Net;

namespace Hackathon.API.DTOs
{
    public class UserDTO
    {
        public string EmailAdress { get; set; }
        public string UserPassword { get; set; }

        public void RegisterUser(UserDTO userDTO)
        {
            var parameters = new DynamicParameters();
            parameters.Add("EmailAdress", userDTO.EmailAdress);
            parameters.Add("UserPassword", userDTO.UserPassword);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("InsertUser",parameters , commandType: CommandType.StoredProcedure);
        }
        public int CheckLoginCredentials(UserDTO credentials)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Email", credentials.EmailAdress);
            parameters.Add("Password", credentials.UserPassword);
            parameters.Add("UserId", DbType.Int32, direction: ParameterDirection.Output);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("CheckLoginCredentials", parameters, commandType: CommandType.StoredProcedure);
            int UserId = parameters.Get<int>("UserId");
            if (UserId!=-1)
            {
                return UserId;
            }
            return 0;
        }
        public IEnumerable<double> getCo2Levels(int UserId)
        {
            IEnumerable<double> levels = new List<double>();
            var parameters = new DynamicParameters();
            parameters.Add("IdUser", UserId);
            DataBaseConnection connection = new DataBaseConnection();
            var con = connection.ConnectToDataBase();
            
            var result = con.Query<double>("getCO2Levels",parameters, commandType: CommandType.StoredProcedure);
            if (result != null)
            {
                return result;
            }
            else
            {
                return levels;
            }

        }
    }
}
