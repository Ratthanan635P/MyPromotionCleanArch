using Microsoft.EntityFrameworkCore;
using MyPromotionCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyPromotionCleanArch.DataAccess.Contexts
{
	public class PromotionContext:DbContext
	{
		//Dbset
		public DbSet<User> Users { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<MapCustomerPromotion> MapCustomerPromotions { get; set; }

		//Config
	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=localhost;Database=MyPromotionCleanArch;Trusted_Connection=True;User Id=sa;Password=yourStrong(!)Password;Integrated Security=false;");
			}
		}
		//OnModelCreate
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
