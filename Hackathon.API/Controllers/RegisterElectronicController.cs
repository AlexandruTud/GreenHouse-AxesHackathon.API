using Dapper;
using Hackathon.API.DTOs;
using Hackathon.API.Entities;
using Hackathon.API.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/registerElectronic")]
    public class RegisterElectronicController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult InsertElectronic([FromBody]ElectronicsDTO electronic)
        {
            var parameters = new DynamicParameters();
            parameters.Add("UserId", electronic.IdUser);
            parameters.Add("PartnerId", electronic.returnPartnerID(electronic.namePartner));
            parameters.Add("CategoryId", electronic.returnCategoryID(electronic.CategoryName));
            parameters.Add("Model", electronic.Model);
            parameters.Add("Series", electronic.Series);
            parameters.Add("EnergeticClass", electronic.EnergeticClass);
            parameters.Add("EnergyUsed", electronic.EnergyUsed);
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            var conection = dataBaseConnection.ConnectToDataBase();
            conection.Execute("InsertElectronics",parameters, commandType : CommandType.StoredProcedure);
            return Ok("Electronic device added successfully!");
        }
    }
}
