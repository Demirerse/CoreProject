using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concretes
{
    public class TagManager : BaseManager<Tag>, ITagManager
    {
        public TagManager(IRepository<Tag> irep) : base(irep)
        {
        }
        public override string Add(Tag item)
        {


            if (item.TagName != null)
            {
                _iRep.Add(item);
                return "Etiket eklendi";
            }
            return "Etiket ismi girilmemiş";
        }
    }
}
