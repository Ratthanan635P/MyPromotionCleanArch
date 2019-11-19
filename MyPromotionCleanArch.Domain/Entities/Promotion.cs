using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.Domain.Entities
{
	public class Promotion: BaseEntity
	{
		
		public string ImagePath { get; set; }
		public string Title { get; set; }
		public string Detail { get; set; }
		public DateTime Expired { get; set; }
		public string Company { get; set; }
	
		public User CreateBy { get; set; }
		public User UpdateBy { get; set; }
		public int Amount { get; set; }		 
	}
}
