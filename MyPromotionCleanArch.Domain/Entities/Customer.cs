using MyPromotionCleanArch.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPromotionCleanArch.Domain.Entities
{
	public class Customer:BaseEntity
	{
		//public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public Enums.Gender Gender { get; set; }
		public DateTime BirthDate { get; set; }
		public string Nationality { get; set; }
		public string CitizenId { get; set; }
		//public DateTime CreateDateTime { get; set; }
		//	public DateTime UpdateDateTime { get; set; }
		//public List<Promotion> Promotions { get; set; }

	}
}
