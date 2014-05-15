using CustomUserStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CustomUserStore.App_Start
{
    public class StubUserStore<TUser> : IUserStore<TUser>, IUserStore<TUser, string>, IUserPasswordStore<TUser>, IUserPasswordStore<TUser, string>, IDisposable where TUser : global::Microsoft.AspNet.Identity.EntityFramework.IdentityUser
    {
        public Task CreateAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task<TUser> FindByIdAsync(string userId)
        {
            TUser user = new ApplicationUser() { Id = "1", Email = "Alice@mail.com", UserName = "Alice@mail.com" } as TUser;

            return Task.FromResult<TUser>(user);
        }

        public Task<TUser> FindByNameAsync(string userName)
        {
            TUser user = new ApplicationUser() { Id = "1", Email = "Alice@mail.com", UserName = "Alice@mail.com" } as TUser;

            return Task.FromResult<TUser>(user); 
        }

        public Task UpdateAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(TUser user)
        {

            //user.PasswordHash = "AED7HfKdNxNU0C/ZsWqcSlirrdFqQ2HBiquLnKycTMj6GQ09FbNuDNSID2A589TDhw==";
            user.PasswordHash = "Password123!";

            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(TUser user, string passwordHash)
        {
            throw new NotImplementedException();
        }


    }
}