using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concretes
{
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        public CategoryManager(IRepository<Category> irep) : base(irep)
        {
        }
        public override string Add(Category item)
        {


            if (item.CategoryName != null)
            {
                _iRep.Add(item);
                return "Kategori eklendi";
            }
            return "Kategori ismi girilmemiş";
        }
    }
}
