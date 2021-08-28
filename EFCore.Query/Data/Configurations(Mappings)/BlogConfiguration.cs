﻿using EFCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Query.Data.Configurations_Mappings_
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(250);

            builder.Property(x => x.Url).HasMaxLength(300);
        }
    }
}
