
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace atmsystem
{
	public partial class Deposit
	{
		public Deposit()
		{
			InitializeComponent();
			
		}
		
#region Default Instance
		
		private static Deposit defaultInstance;
		
		
		public static Deposit Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Deposit();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
		DataSet dset = new DataSet();
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		string balance;
		int num1;
		int num2;
		int total;
		
		public void Deposit_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
			lblaccno.Text = Mainmenu.Default.lblaccno.Text;
		}
		
		public void btnok_Click(System.Object sender, System.EventArgs e)
		{
			string sql = default(string);
			DataTable Log_in = new DataTable();
			
			try
			{					
				con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ATMsystem.accdb";
				sql = "SELECT * FROM tblinfo where  account_no = " + lblaccno.Text + "";
				
				cmd.Connection = con;
				cmd.CommandText = sql;
				da.SelectCommand = cmd;
				da.Fill(Log_in);
				if (Log_in.Rows.Count > 0)
				{
					balance = (string) (Log_in.Rows[0]["balance"]);
					num1 = int.Parse(balance);
					num2 = int.Parse(txtamount.Text);
					
					if (num2 > 25000)
					{
						MessageBox.Show("You can Only Deposit Rs.25,000!");
					}
					else if (num2 < 200)
					{
						MessageBox.Show(" Mininum Deposit is 200");
						
						
					}
					else
					{
						total = num1 + num2;
						
						Receipt.Default.Show();
						
						Receipt.Default.lblbal.Text = balance;
						Receipt.Default.Label3.Hide();
						Receipt.Default.lblwith.Hide();
						Receipt.Default.lbldep.Text = num2.ToString();
						Receipt.Default.lblnewbal.Text = total.ToString();
						
						Receipt.Default.Label5.Show();
						Receipt.Default.Label6.Show();
						
						
						Receipt.Default.lblbal.Show();
						Receipt.Default.Label3.Hide();
						Receipt.Default.lblwith.Hide();
						Receipt.Default.lbldep.Show();
						Receipt.Default.lblnewbal.Show();
						//MsgBox("success")
						Receipt.Default.lblname.Text = Mainmenu.Default.lblname.Text;
						this.Hide();
						
						
					}
				}
				else
				{
					
					
				}
				
				
				
				
				
				
			}
			catch (Exception)
			{
				MessageBox.Show(" Pls. Enter Ammount!");
				//MsgBox(ex.Message)
			}
			txtamount.Text = "";
			
			
			
		}
		
		public void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Mainmenu.Default.Show();
			this.Hide();
			
		}
		
		public void txtamount_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void lbldate_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
