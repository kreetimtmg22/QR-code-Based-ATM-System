
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
	public partial class Login_frm
	{
		public Login_frm()
		{
			InitializeComponent();

		}


		
#region Default Instance
		
		private static Login_frm defaultInstance;
		

		public static Login_frm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Login_frm();
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
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		DataSet ds = new DataSet();
		System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
		
		
		
		
		public void Login_frm_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
			qrCode.Default.Show();
			this.Hide();
        }
    }
	
}
