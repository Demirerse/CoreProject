using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concretes
{
    public class ArticleTagManager : BaseManager<ArticleTag>, IArticleTagManager
    {
        public ArticleTagManager(IRepository<ArticleTag> irep) : base(irep)
        {
        }
    }
}
