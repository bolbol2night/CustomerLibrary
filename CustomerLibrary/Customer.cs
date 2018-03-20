using System;

namespace CustomerLibrary
{
	public class Customer
	{
		public static readonly string EmptyName = "Customer Name is required !!!";
		public static readonly string EmptyPhoneNumber = "Customer PhoneNumber is required !!!";
		public static readonly string PositifBillAmount = "Customer Bill Amount is required !!!";
		public static readonly string FutureBillDate = "Customer Bill Date is required !!!";

		public string CustomerName { get; set; }
		public string PhoneNumber { get; set; }
		public double BillAmount { get; set; }
		public DateTime BillDate { get; set; }
		public string Address { get; set; }

		public virtual void Validate()
		{
			if (CustomerName.Length == 0)
			{
				throw new Exception(EmptyName);
			}
			if (PhoneNumber.Length == 0)
			{
				throw new Exception(EmptyPhoneNumber);
			}
			if (BillAmount > 0)
			{
				throw new Exception(PositifBillAmount);
			}
			if (BillDate > DateTime.Now)
			{
				throw new Exception(FutureBillDate);
			}

			throw new NotImplementedException();
		}
	}
}