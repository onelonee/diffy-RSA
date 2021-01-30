namespace TestNetClient
{
	partial class Client
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
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btSendText = new System.Windows.Forms.Button();
            this.tbSourceText = new System.Windows.Forms.TextBox();
            this.lbSourceText = new System.Windows.Forms.Label();
            this.tbData1 = new System.Windows.Forms.TextBox();
            this.tbData2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrivateKeyA = new System.Windows.Forms.Label();
            this.tbPrivateKeyA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(15, 40);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(537, 303);
            this.lbLog.TabIndex = 1;
            this.lbLog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(93, 14);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(274, 20);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "192.168.0.105";
            // 
            // btSendText
            // 
            this.btSendText.Location = new System.Drawing.Point(452, 406);
            this.btSendText.Name = "btSendText";
            this.btSendText.Size = new System.Drawing.Size(100, 23);
            this.btSendText.TabIndex = 6;
            this.btSendText.Text = "RSACrypt";
            this.btSendText.UseVisualStyleBackColor = true;
            this.btSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // tbSourceText
            // 
            this.tbSourceText.Location = new System.Drawing.Point(93, 364);
            this.tbSourceText.Name = "tbSourceText";
            this.tbSourceText.Size = new System.Drawing.Size(274, 20);
            this.tbSourceText.TabIndex = 8;
            this.tbSourceText.Text = "Nice! Two rolls!";
            // 
            // lbSourceText
            // 
            this.lbSourceText.AutoSize = true;
            this.lbSourceText.Location = new System.Drawing.Point(15, 367);
            this.lbSourceText.Name = "lbSourceText";
            this.lbSourceText.Size = new System.Drawing.Size(65, 13);
            this.lbSourceText.TabIndex = 11;
            this.lbSourceText.Text = "SourceText:";
            // 
            // tbData1
            // 
            this.tbData1.Location = new System.Drawing.Point(452, 354);
            this.tbData1.Name = "tbData1";
            this.tbData1.Size = new System.Drawing.Size(100, 20);
            this.tbData1.TabIndex = 15;
            this.tbData1.Text = "61";
            // 
            // tbData2
            // 
            this.tbData2.Location = new System.Drawing.Point(452, 380);
            this.tbData2.Name = "tbData2";
            this.tbData2.Size = new System.Drawing.Size(100, 20);
            this.tbData2.TabIndex = 16;
            this.tbData2.Text = "97";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "FirstPrime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SecondPrime:";
            // 
            // lbPrivateKeyA
            // 
            this.lbPrivateKeyA.AutoSize = true;
            this.lbPrivateKeyA.Location = new System.Drawing.Point(373, 17);
            this.lbPrivateKeyA.Name = "lbPrivateKeyA";
            this.lbPrivateKeyA.Size = new System.Drawing.Size(71, 13);
            this.lbPrivateKeyA.TabIndex = 19;
            this.lbPrivateKeyA.Text = "PrivateKey-A:";
            // 
            // tbPrivateKeyA
            // 
            this.tbPrivateKeyA.Location = new System.Drawing.Point(452, 14);
            this.tbPrivateKeyA.Name = "tbPrivateKeyA";
            this.tbPrivateKeyA.Size = new System.Drawing.Size(100, 20);
            this.tbPrivateKeyA.TabIndex = 20;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 435);
            this.Controls.Add(this.tbPrivateKeyA);
            this.Controls.Add(this.lbPrivateKeyA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbData2);
            this.Controls.Add(this.tbData1);
            this.Controls.Add(this.lbSourceText);
            this.Controls.Add(this.tbSourceText);
            this.Controls.Add(this.btSendText);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lbLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox lbLog;
		private System.Windows.Forms.Button btConnect;
		private System.Windows.Forms.TextBox tbIP;
		private System.Windows.Forms.Button btSendText;
        private System.Windows.Forms.TextBox tbSourceText;
        private System.Windows.Forms.Label lbSourceText;
        public System.Windows.Forms.TextBox tbData1;
        public System.Windows.Forms.TextBox tbData2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrivateKeyA;
        private System.Windows.Forms.TextBox tbPrivateKeyA;
    }
}

