﻿using Project.DAL.Context;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class ProfileRepository:BaseRepository<AppUserProfile>, IProfileRepository
    {
        public ProfileRepository(MyContext db):base(db)
        {

        }
    }
}
