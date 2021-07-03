using Project.DAL.Context;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class EditorRepository : BaseRepository<Editor>, IEditorRepository
    {
        public EditorRepository(MyContext db) : base(db)
        {
        }
    }
}
