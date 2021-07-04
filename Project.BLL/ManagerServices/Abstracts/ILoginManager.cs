using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface ILoginManager
    {
        Task<bool> SignInUser(AppUser item, bool remember);
    }
}
