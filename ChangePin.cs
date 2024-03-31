using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace atmsystem
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
        System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
        DataSet ds = new DataSet();
        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();

        public static object Default { get; internal set; }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (Pn1.Text == Pn2.Text)
            {
                string dbcommand = "INSERT into tblinfo ( pin_code )" + " VALUES (\'" + Pn1.Text + "\')";
                System.Data.OleDb.OleDbDataAdapter adapt = new System.Data.OleDb.OleDbDataAdapter(dbcommand, conn);
                DataSet dset = new DataSet();
                adapt.Fill(dset);
            }
            else if (Pin2tb.Text != Pin1tb.Text)
            {
                MessageBox.Show("Pin1 and Pin2 are Different");
            }
            else
            {
               
            }
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void Pn1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
