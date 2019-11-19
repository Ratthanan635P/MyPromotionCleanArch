using MyPromotionCleanArch.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.Domain.Entities
{
	public class User:BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public Enums.UserRole Role { get; set; }
		//public List<Promotion> CreateByPromotion { get; set; }
		//public List<Promotion> UpdateByPromotion { get; set; }
	}
	
}
