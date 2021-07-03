using Project.DAL.Context;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(MyContext db) : base(db)
        {
        }
    }
}
