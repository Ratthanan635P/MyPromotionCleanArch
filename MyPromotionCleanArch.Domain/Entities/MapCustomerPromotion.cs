using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.Domain.Entities
{
	public class MapCustomerPromotion : BaseEntity
	{
		public Customer Customer { get; set; }
		public Promotion Promotion { get; set; }
		public string Code { get; set; }
		public bool IsUsed { get; set; }

	}
}
