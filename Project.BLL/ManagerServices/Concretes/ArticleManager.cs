using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concretes
{
    public class ArticleManager : BaseManager<Article>, IArticleManager
    {
        public ArticleManager(IRepository<Article> irep) : base(irep)
        {
        }
        public override string Add(Article item)
        {


            if (item.Title != null)
            {
                _iRep.Add(item);
                return "Başlık eklendi";
            }
            return "Başlık ismi girilmemiş";
        }
    }
}
