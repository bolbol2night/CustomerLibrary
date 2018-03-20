using System;

namespace CustomerLibrary
{
	public class Customer: CustomerBase
	{
		public static readonly string EmptyName = "Customer Name is required !!!";
		public static readonly string EmptyPhoneNumber = "Customer PhoneNumber is required !!!";
		public static readonly string PositifBillAmount = "Customer Bill Amount is required !!!";
		public static readonly string FutureBillDate = "Customer Bill Date is required !!!";

		public override void Validate()
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