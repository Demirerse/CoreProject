using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public class ArticleTag:BaseEntity, IEntity
    {
        public int ArticleID { get; set; }
        public int TagID { get; set; }


        //Relational Properties
        public virtual Article Article { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
