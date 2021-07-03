using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configuration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.CreatedDate).HasColumnName("Yaratma Tarihi");
            builder.Property(X => X.ModifiedDate).HasColumnName("Güncelleme Tarihi");
            builder.Property(X => X.DeletedDate).HasColumnName("Silme Tarihi");
        }
    }
}
