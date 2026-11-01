using EF_Assignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(B => B.BadgeNumber);

            builder.HasOne(A => A.Owner)
                 .WithOne(B => B.AttendeeBadge)
                 .HasForeignKey<Badge>(nameof(Badge.OwnerId));
        }
    }
}
