using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICustomerInterface;

namespace WindowsCustomerUI
{
	public partial class CustomerUI : Form
	{
		public CustomerUI()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, MouseEventArgs e)
		{
			ICustomer icust = null;
			icust = Factory.Create(cmbCustomerType.SelectedIndex);
			icust.CustomerName = txtCustomerName.Text;
			icust.Address = txtAddress.Text;
			icust.PhoneNumber = txtPhoneNumber.Text;
			icust.BillDate = Convert.ToDateTime(txtBillingDate.Text);
			icust.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
		}
	}
}
