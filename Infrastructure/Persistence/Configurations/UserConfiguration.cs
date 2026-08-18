using FintechWallet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class  UserConfiguration : IEntityTypeConfiguration<User>
    
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id); // Configura la clave primaria

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50); // Configura la propiedad FirstName
            
            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50); // Configura la propiedad LastName

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100); // Configura la propiedad Email
            builder.Property(u => u.CreatedAt)
                .IsRequired(); // Configura la propiedad CreatedAt
        }
    }
}
