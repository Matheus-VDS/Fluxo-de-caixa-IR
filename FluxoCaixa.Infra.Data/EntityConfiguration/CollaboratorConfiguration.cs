﻿using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class CollaboratorConfiguration : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.FullName)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.DateBirth)
                .IsRequired();

            entity.Property(p => p.Status)
                .IsRequired();

            entity.Property(p => p.UserIncluded)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.DateIncluded)
               .IsRequired();

            entity.Property(p => p.UserChanged)
                .HasMaxLength(50);

            entity.Property(p => p.AddressID)
                .IsRequired();

            entity.Property(p => p.CollaboratorTypeID)
                .IsRequired();
        }
    }
}