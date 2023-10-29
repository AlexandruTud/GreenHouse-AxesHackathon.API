using Dapper;
using Hackathon.API.Infrastructure;
using Microsoft.OpenApi.Any;
using System.Data;
using System.Data.Common;

namespace Hackathon.API.DTOs
{
    public class ElectronicsDTO
    {
        public int IdElectronic { get; set; }
        public int IdUser { get; set; }
        public string namePartner { get; set; }
        public string CategoryName { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public string EnergeticClass { get; set; }
        public string EnergyUsed { get; set; }

        public int returnPartnerID (string PartnerName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("PartnerName", PartnerName);
            parameters.Add("PartnerId", DbType.Int32, direction: ParameterDirection.Output);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("GetPartnerIdByPartnerName", parameters, commandType: CommandType.StoredProcedure);
            int PartnerId = parameters.Get<int>("PartnerId");
            return PartnerId;
        }
        public int returnCategoryID(string CategoryName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("CategoryName", CategoryName);
            parameters.Add("CategoryId", DbType.Int32, direction: ParameterDirection.Output);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var connection = dataBaseConnection.ConnectToDataBase();
            connection.Execute("GetCategoryIdByCategoryName", parameters, commandType: CommandType.StoredProcedure);
            int CategoryId = parameters.Get<int>("CategoryId");
            return CategoryId;
        }

        public IEnumerable<ElectronicsDTO> returnElectronicsList(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            DataBaseConnection connection = new DataBaseConnection();
            var dbConnection = connection.ConnectToDataBase();
            var result = dbConnection.Query<ElectronicsDTO>("GetElectronicsById", parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
        public IEnumerable<ElectronicsDTO> returnBestElectronicsById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdUser", id);
            DataBaseConnection connection = new DataBaseConnection();
            var dbConnection = connection.ConnectToDataBase();
            var result = dbConnection.Query<ElectronicsDTO>("GetBestElectronics", parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void DeleteDeviceById(int idDevice)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdDevice", idDevice);
            DataBaseConnection connection = new DataBaseConnection();
            var dbConnection = connection.ConnectToDataBase();
            dbConnection.Execute("DeleteDeviceById", parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
