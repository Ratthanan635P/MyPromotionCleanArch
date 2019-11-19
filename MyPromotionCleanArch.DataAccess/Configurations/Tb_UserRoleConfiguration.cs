using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPromotionCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.DataAccess.Configurations
{
	public class Tb_UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
	{
		//builder.ToTable("Tb_UserRole");
		public void Configure(EntityTypeBuilder<UserRole> builder)
		{
			//throw new NotImplementedException();
			builder.ToTable("Tb_UserRole");
		}
	}
}
