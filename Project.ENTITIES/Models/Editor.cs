using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public class Editor:BaseEntity, IEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        public virtual List<Article> Articles { get; set; }
    }
}
