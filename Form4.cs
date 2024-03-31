using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Text;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class qrCode : Form
    {
        public qrCode()
        {
            InitializeComponent();
        }

        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice FinalFrame;

        #region Default Instance

        private static qrCode defaultInstance;


        public static qrCode Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new qrCode();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        public FilterInfoCollection CaptureDevice { get; private set; }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion
        string constr;
        System.Data.OleDb.OleDbDataAdapter adapt;
        System.Data.OleDb.OleDbDataAdapter adapt1 = new System.Data.OleDb.OleDbDataAdapter();
        System.Data.OleDb.OleDbConnection conn;
        DataSet dset = new DataSet();

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void qrCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice) 
            { 
                comboBox1.Items.Add(Device.Name);
            
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

       

        private void qrCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            textBox1.Text = "";

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                textBox1.Text = decoded;

                if (decoded == "12345")
                {
                    timer1.Stop();
                    button2.Enabled=true;
                    textBox1.Text = decoded;
                    pin frm = new pin();
                    frm.Show();
                    this.Hide();
                }

                else if(decoded == "09876")
                {
                    timer1.Stop();
                    button2.Enabled = true;
                    textBox1.Text = decoded;
                    pin frm = new pin();
                    frm.Show();
                    this.Hide();
                }
                else if (decoded == "19999")
                {
                    timer1.Stop();
                    button2.Enabled = true;
                    textBox1.Text = decoded;
                    pin frm = new pin();
                    frm.Show();
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
            
            }
        }

        private void llblreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regs_frm.Default.Show();
            this.Hide();
        }
    }
}
