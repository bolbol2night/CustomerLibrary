using System;

namespace CustomerLibrary
{
	public class Lead: CustomerBase
	{
		public static readonly string EmptyName = "Customer Name is required !!!";
		public static readonly string EmptyPhoneNumber = "Customer PhoneNumber is required !!!";

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
		}
	}
}