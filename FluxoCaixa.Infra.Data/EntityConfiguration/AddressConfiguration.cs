﻿using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.Street)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.CEP)
                .HasMaxLength(8)
                .IsRequired();

            entity.Property(p => p.City)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.State)
                .HasMaxLength(50)
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
        }
    }
}