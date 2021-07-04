using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.DAL.Repositories.Concretes;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class UserIdentityManager : IUserIdentityManager
    {

        IAppUserRepository _apRep;

        public UserIdentityManager(IAppUserRepository apRep)
        {
            _apRep = apRep;
        }
        public async Task<bool> AddUser(AppUser item)
        {
            if (!string.IsNullOrEmpty(item.UserName) && !string.IsNullOrEmpty(item.PasswordHash))
            {
                return await _apRep.AddUser(item);

            }
            return false;
        }
    }
}
