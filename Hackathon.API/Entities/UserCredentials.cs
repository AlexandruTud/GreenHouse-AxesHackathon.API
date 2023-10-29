using Dapper;
using Hackathon.API.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Hackathon.API.Entities
{
    public class UserCredentials
    {
        public int IdUser { get; set; }
        public string EmailAdress { get; set; }

        public string UserPassword { get; set; }

        public List<UserRoles> userRoles { get; set; }

    }
}