using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPromotionCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.DataAccess.Configurations
{
	public class Tb_MapCustomerPromotionConfiguration : IEntityTypeConfiguration<MapCustomerPromotion>
	{
		public void Configure(EntityTypeBuilder<MapCustomerPromotion> builder)
		{
			//throw new NotImplementedException();
			builder.ToTable("Tb_MapCustomerPromotion");
			builder.Property(e => e.Code)
				   .HasMaxLength(10)
				   .IsRequired();
		}
	}
}
