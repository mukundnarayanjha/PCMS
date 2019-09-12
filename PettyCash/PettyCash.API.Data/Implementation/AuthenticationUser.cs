using PettyCash.API.Common.Repository;
using PettyCash.API.Data.Interface;
using PettyCash.API.Models.AuthUser;
using PettyCash.API.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyCash.API.Data.Implementation
{
   public class AuthenticationUser : RepositoryBase<User>, IAuthenticationUser
    {
        public AuthenticationUser(ApplicationDbContext context) : base(context)
        { }

      
        public async Task<User> GetAuthenticatedUserAsync(string key1, string key2)
        {
            var user = await FindByConditionAync(o => o.EmailId.Equals(key1) && o.Password.Equals(key2));
            return user.FirstOrDefault();
        }

    }
}
