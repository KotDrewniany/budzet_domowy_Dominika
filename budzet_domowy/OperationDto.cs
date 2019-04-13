using System;

namespace budzet_domowy
{
	public class OperationDto
	{
		public int Id { get; set; }

		public DateTime Data { get; set; }

		public decimal Price { get; set; }

		public int CategoryId { get; set; }

		public int UserId { get; set; }

		public int? PaymentFormId { get; set; }

		public string Description { get; set; }
	}
}