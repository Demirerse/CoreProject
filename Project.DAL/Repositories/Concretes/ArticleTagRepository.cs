using Project.DAL.Context;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class ArticleTagRepository : BaseRepository<ArticleTag>, IArticleTagRepository
    {
        public ArticleTagRepository(MyContext db) : base(db)
        {
        }
    }
}
