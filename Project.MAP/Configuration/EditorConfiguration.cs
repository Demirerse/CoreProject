using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configuration
{
    public class EditorConfiguration:BaseConfiguration<Editor>
    {
        public override void Configure(EntityTypeBuilder<Editor> builder)
        {
            base.Configure(builder);
        }
    }
}
