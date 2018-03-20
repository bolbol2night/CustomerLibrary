using System;

namespace CustomerLibrary
{
	public class CustomerBase
	{
		public string CustomerName { get; set; }
		public string PhoneNumber { get; set; }
		public double BillAmount { get; set; }
		public DateTime BillDate { get; set; }
		public string Address { get; set; }

		public virtual void Validate()
		{
		}
	}
}
