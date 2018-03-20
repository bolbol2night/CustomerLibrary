using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CustomerLibrary;

namespace CustomerLibraryTest
{
	[TestClass]
	public class LeedTest
	{
		private Lead lead;

		[TestInitialize]
		public void LeadInitialization()
		{
			lead = new Lead
			{
				CustomerName = "Bilel BELHADJ",
				PhoneNumber = "0123456789",
				BillAmount = 0,
				BillDate = DateTime.Now,
				Address = "16 Rue de Provence, 94230 Cachan"
			};
		}

		[TestMethod]
		public void Lead_WithEmptyName_ThrowsException()
		{
			// arrange
			lead.CustomerName = "";

			// act
			try
			{
				lead.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.EmptyName);
				return;
			}
			Assert.Fail("Lead with empty name didn't throw Excception !!!");
		}

		[TestMethod]
		public void Lead_WithEmptyPhoneNumber_ThrowsException()
		{
			// arrange
			lead.PhoneNumber = "";

			// act
			try
			{
				lead.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.EmptyPhoneNumber);
				return;
			}
			Assert.Fail("Lead with empty phone number didn't throw Excception !!!");
		}

		[TestMethod]
		public void Lead_WithPositifBillAmount_DoesntThrowsException()
		{
			// arrange
			lead.BillAmount = 100;

			// act
			try
			{
				lead.Validate();
			}
			// assert
			catch (Exception e)
			{
				Assert.Fail("Lead with positif bill amount did throw Excception: {0} !!!", e);
				return;
			}
		}

		[TestMethod]
		public void Lead_WithBillDateInFuture_ThrowsException()
		{
			// arrange
			lead.BillDate = DateTime.Parse("21-MAR-2018");

			// act
			try
			{
				lead.Validate();
			}
			// assert
			catch (Exception e)
			{
				Assert.Fail("Lead with bill date in future did throw Excception: {0} !!!", e);
				return;
			}
		}

		[TestCleanup]
		public void LeadCleanup() => lead = null;
	}

	[TestClass]
	public class CustomerTest
	{
		private Customer customer;

		[TestInitialize]
		public void CustomerInitialization()
		{
			customer = new Customer
			{
				CustomerName = "Bilel BELHADJ",
				PhoneNumber = "0634938557",
				BillAmount = 0,
				BillDate = DateTime.Now,
				Address = "16 Rue de Provence, 94230 Cachan"
			};
		}

		[TestMethod]
		public void Customer_WithEmptyName_ThrowsException()
		{
			// arrange
			customer.CustomerName = "";

			// act
			try
			{
				customer.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.EmptyName);
				return;
			}
			Assert.Fail("Customer with empty name didn't throw Excception !!!");
		}

		[TestMethod]
		public void Customer_WithEmptyPhoneNumber_ThrowsException()
		{
			// arrange
			customer.PhoneNumber = "";

			// act
			try
			{
				customer.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.EmptyPhoneNumber);
				return;
			}
			Assert.Fail("Customer with empty phone number didn't throw Excception !!!");
		}

		[TestMethod]
		public void Customer_WithPositifBillAmount_ThrowsException()
		{
			// arrange
			customer.BillAmount = 100;

			// act
			try
			{
				customer.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.PositifBillAmount);
				return;
			}
			Assert.Fail("Customer with positif bill amount didn't throw Excception !!!");
		}

		[TestMethod]
		public void Customer_WithBillDateInFuture_ThrowsException()
		{
			// arrange
			customer.BillDate = DateTime.Parse("21-MAR-2018");

			// act
			try
			{
				customer.Validate();
			}
			// assert
			catch (Exception e)
			{
				StringAssert.Contains(e.Message, Customer.FutureBillDate);
				return;
			}
			Assert.Fail("Customer with bill date in future didn't throw Excception !!!");
		}

		[TestCleanup]
		public void CustomerCleanup() => customer = null;
	}

	[TestClass]
	public class CustomerBaseTest
	{
		private CustomerBase customer;
		private CustomerBase lead;

		[TestInitialize]
		public void CustomerBaseInitialization()
		{
			customer = new Customer
			{
				CustomerName = "Bilel BELHADJ",
				PhoneNumber = "0634938557",
				BillAmount = 0,
				BillDate = DateTime.Now,
				Address = "16 Rue de Provence, 94230 Cachan"
			};

			lead = new Lead
			{
				CustomerName = "Bilel BELHADJ",
				PhoneNumber = "0123456789",
				BillAmount = 0,
				BillDate = DateTime.Now,
				Address = "16 Rue de Provence, 94230 Cachan"
			};
		}

		[TestCleanup]
		public void CustomerBaseCleanup()
		{
			customer = null;
			lead = null;
		}
	}
}

