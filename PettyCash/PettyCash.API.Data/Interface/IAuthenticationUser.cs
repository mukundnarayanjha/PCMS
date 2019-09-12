using PettyCash.API.Models.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PettyCash.API.Data.Interface
{
    public interface IAuthenticationUser
    {
        Task<User> GetAuthenticatedUserAsync(string Key1, string Key2);
    }
}
