using Microsoft.AspNetCore.Identity;
using Project.DAL.Context;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public AppUserRepository(MyContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> AddUser(AppUser item)
        {


            IdentityResult result = await _userManager.CreateAsync(item, item.PasswordHash);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(item, isPersistent: false);
                return true;
            }
            return false;

        }
    }
}
