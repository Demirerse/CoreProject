using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    //Dikkat ederseniz burada olusturdugumuz Interface IRepository isimli Interface'den miras almamaktadır. Bunun nedeni bu Interface'in normal Manual Manager Interface'lerinden bagımsız ama kendi basına Identity'ye bagımlısı olmasının gerekmesidir...
    public  interface IUserIdentityManager
    {
        Task<bool> AddUser(AppUser item);
    }
}
