using Microsoft.AspNetCore.Identity;
using Project.BLL.ManagerServices.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class LoginManager : ILoginManager
    {
        SignInManager<AppUser> _sManager;

        public LoginManager(SignInManager<AppUser> sManager)
        {
            _sManager = sManager;
        }


        public async Task<bool> SignInUser(AppUser item, bool remember)
        {

            if (!string.IsNullOrEmpty(item.UserName) && !string.IsNullOrEmpty(item.PasswordHash))
            {

                SignInResult result = await _sManager.PasswordSignInAsync(item.UserName, item.PasswordHash, remember, false);
                if (result.Succeeded)return true;

                
               
                return false;


            }


          
            return false;



        }
    }
}
