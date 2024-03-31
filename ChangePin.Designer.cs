namespace atmsystem
{
    partial class ChangePin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pin1tb = new System.Windows.Forms.Label();
            this.Pin2tb = new System.Windows.Forms.Label();
            this.Pn1 = new System.Windows.Forms.TextBox();
            this.Pn2 = new System.Windows.Forms.TextBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 63);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "AUTOMATED TELLER MACHINE";
            // 
            // Pin1tb
            // 
            this.Pin1tb.AutoSize = true;
            this.Pin1tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin1tb.Location = new System.Drawing.Point(68, 123);
            this.Pin1tb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pin1tb.Name = "Pin1tb";
            this.Pin1tb.Size = new System.Drawing.Size(110, 25);
            this.Pin1tb.TabIndex = 34;
            this.Pin1tb.Text = "NEW PIN:";
            // 
            // Pin2tb
            // 
            this.Pin2tb.AutoSize = true;
            this.Pin2tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin2tb.Location = new System.Drawing.Point(68, 179);
            this.Pin2tb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pin2tb.Name = "Pin2tb";
            this.Pin2tb.Size = new System.Drawing.Size(159, 25);
            this.Pin2tb.TabIndex = 35;
            this.Pin2tb.Text = "CONFIRM PIN:";
            // 
            // Pn1
            // 
            this.Pn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn1.Location = new System.Drawing.Point(260, 112);
            this.Pn1.Margin = new System.Windows.Forms.Padding(4);
            this.Pn1.Multiline = true;
            this.Pn1.Name = "Pn1";
            this.Pn1.Size = new System.Drawing.Size(177, 36);
            this.Pn1.TabIndex = 36;
            this.Pn1.TextChanged += new System.EventHandler(this.Pn1_TextChanged);
            // 
            // Pn2
            // 
            this.Pn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn2.Location = new System.Drawing.Point(260, 179);
            this.Pn2.Margin = new System.Windows.Forms.Padding(4);
            this.Pn2.Multiline = true;
            this.Pn2.Name = "Pn2";
            this.Pn2.Size = new System.Drawing.Size(177, 36);
            this.Pn2.TabIndex = 37;
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnchange.ForeColor = System.Drawing.Color.Transparent;
            this.btnchange.Location = new System.Drawing.Point(308, 237);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(93, 44);
            this.btnchange.TabIndex = 38;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(514, 337);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.Pn2);
            this.Controls.Add(this.Pn1);
            this.Controls.Add(this.Pin2tb);
            this.Controls.Add(this.Pin1tb);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Pin1tb;
        internal System.Windows.Forms.Label Pin2tb;
        internal System.Windows.Forms.TextBox Pn1;
        internal System.Windows.Forms.TextBox Pn2;
        private System.Windows.Forms.Button btnchange;
    }
}