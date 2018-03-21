namespace WindowsCustomerUI
{
	partial class CustomerUI
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbCustomerType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtBillingDate = new System.Windows.Forms.DateTimePicker();
			this.txtBillingAmount = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbCustomerType
			// 
			this.cmbCustomerType.DisplayMember = "Lead;Customer";
			this.cmbCustomerType.FormattingEnabled = true;
			this.cmbCustomerType.Location = new System.Drawing.Point(92, 12);
			this.cmbCustomerType.Name = "cmbCustomerType";
			this.cmbCustomerType.Size = new System.Drawing.Size(110, 21);
			this.cmbCustomerType.TabIndex = 0;
			this.cmbCustomerType.ValueMember = "Lead;Customer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customer Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Name";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(92, 43);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(110, 20);
			this.txtCustomerName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phone Number";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(92, 73);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(110, 20);
			this.txtPhoneNumber.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(225, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Bill Amount";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(238, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Bill Date";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(239, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Address";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(290, 67);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(159, 64);
			this.txtAddress.TabIndex = 9;
			// 
			// txtBillingDate
			// 
			this.txtBillingDate.Location = new System.Drawing.Point(290, 40);
			this.txtBillingDate.Name = "txtBillingDate";
			this.txtBillingDate.Size = new System.Drawing.Size(159, 20);
			this.txtBillingDate.TabIndex = 10;
			// 
			// txtBillingAmount
			// 
			this.txtBillingAmount.Location = new System.Drawing.Point(290, 13);
			this.txtBillingAmount.Name = "txtBillingAmount";
			this.txtBillingAmount.Size = new System.Drawing.Size(99, 20);
			this.txtBillingAmount.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 102);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(54, 29);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdd_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(88, 102);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(54, 29);
			this.button2.TabIndex = 13;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(148, 102);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(54, 29);
			this.button3.TabIndex = 14;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(208, 102);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(54, 29);
			this.button4.TabIndex = 15;
			this.button4.Text = "Cancel";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 141);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtBillingAmount);
			this.Controls.Add(this.txtBillingDate);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCustomerType);
			this.Name = "Form1";
			this.Text = "Customer screen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCustomerType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.DateTimePicker txtBillingDate;
		private System.Windows.Forms.TextBox txtBillingAmount;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

