using System;

namespace CustomerLibrary
{
	public class Lead: Customer
	{
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