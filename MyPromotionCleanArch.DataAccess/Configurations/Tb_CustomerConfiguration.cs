using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPromotionCleanArch.Domain.Entities;
using MyPromotionCleanArch.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.DataAccess.Configurations
{
	public class Tb_CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			//var converter = new EnumToStringConverter<Enums.Gender>();
			var converter = new ValueConverter<Enums.Gender, string>(
	v => v.ToString(),
	v => (Enums.Gender)Enum.Parse(typeof(Enums.Gender), v));
			//throw new NotImplementedException();
			builder.ToTable("Tb_Customer");
			builder.Property(e => e.Id)
				   .ValueGeneratedOnAdd();

			builder.Property(e => e.Email)
				   .HasMaxLength(50)
				   .IsRequired();

			builder.Property(e => e.CreateDateTime).HasColumnType("datetime");
			builder.Property(e => e.UpdateDateTime).HasColumnType("datetime");
			builder.Property(e => e.BirthDate).HasColumnType("datetime");

			builder.Property(e => e.FirstName)
				   .HasMaxLength(50)
				   .IsRequired();
			builder.Property(e => e.LastName)
				   .HasMaxLength(50)
				   .IsRequired();

			builder.Property(e => e.Password)
				.HasMaxLength(50)
				.IsRequired();
			builder.Property(e => e.Salt)
				.IsRequired();
			builder.Property(e => e.Nationality)
				   .HasMaxLength(50)
				   .IsRequired();
			builder.Property(e => e.CitizenId)
				   .HasMaxLength(50)
				   .IsRequired();
			builder
				.Property(e => e.Gender)
				.HasConversion(converter);
		}
	}
}
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public string Email { get; set; }
//public string Password { get; set; }
//public string Salt { get; set; }
//public Enums.Gender Gender { get; set; }
//public DateTime BirthDate { get; set; }
//public string Nationality { get; set; }
//public string CitizenId { get; set; }
