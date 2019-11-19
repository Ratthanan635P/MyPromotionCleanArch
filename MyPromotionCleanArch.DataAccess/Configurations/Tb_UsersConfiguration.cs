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
	public class Tb_UsersConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			var converter = new EnumToStringConverter<Enums.UserRole>();
			builder.ToTable("Tb_User");
			builder.Property(e => e.Id)
				   .ValueGeneratedOnAdd();
			        
			builder.Property(e => e.CreateDateTime).HasColumnType("datetime");

			builder.Property(e => e.FirstName)
				   .HasMaxLength(50)
				   .IsRequired();
			builder.Property(e => e.LastName)
				   .HasMaxLength(50)
				   .IsRequired();
			builder.Property(e => e.UserName)
				   .HasMaxLength(50)
				   .IsRequired();
			builder.Property(e => e.Password)
				.HasMaxLength(50)
				.IsRequired();
			builder.Property(e => e.Salt)
				.IsRequired();

			//var converter = new EnumToNumberConverter<Enums.UserRole, int>(e=>e.);

			//builder
			//	.Property(e => e.Role)
			//	.HasConversion(converter);

		}
	}
}
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public string UserName { get; set; }
//public string Password { get; set; }
//public string Salt { get; set; }
//public Enums.UserRole Role { get; set; }
//.Entity<Rider>()
//        .Property(e => e.Mount)
//        .HasConversion(
//			v => v.ToString(),
//			v => (EquineBeast) Enum.Parse(typeof(EquineBeast), v));