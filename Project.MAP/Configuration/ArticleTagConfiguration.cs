using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configuration
{
    public class ArticleTagConfiguration:BaseConfiguration<ArticleTag>
    {
        public override void Configure(EntityTypeBuilder<ArticleTag> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.ArticleID,
                x.TagID
            });
        }
    }
}
