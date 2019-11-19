using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPromotionCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.DataAccess.Configurations
{
	public class Tb_PromotionConfiguration : IEntityTypeConfiguration<Promotion>
	{
		public void Configure(EntityTypeBuilder<Promotion> builder)
		{
			//throw new NotImplementedException();
			builder.ToTable("Tb_Promotion");
		}
	}
}
