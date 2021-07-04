using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concretes
{
    public class EditorManager : BaseManager<Editor>, IEditorManager
    {
        public EditorManager(IRepository<Editor> irep) : base(irep)
        {
        }

        public override string Add(Editor item)
        {
            if (item.FirstName !=null)
            {
                _iRep.Add(item);
                return "Ekleme başarılı";
                
            }
            return "Editör ismi boş geçilemez";
        }
    }
}
