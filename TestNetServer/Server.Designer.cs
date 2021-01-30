namespace TestNetServer
{
	partial class Server
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
            this.lblog = new System.Windows.Forms.ListBox();
            this.tbPrivateKeyB = new System.Windows.Forms.TextBox();
            this.lbPrivateKeyB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblog
            // 
            this.lblog.FormattingEnabled = true;
            this.lblog.Location = new System.Drawing.Point(5, 8);
            this.lblog.Name = "lblog";
            this.lblog.Size = new System.Drawing.Size(946, 381);
            this.lblog.TabIndex = 0;
            this.lblog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbPrivateKeyB
            // 
            this.tbPrivateKeyB.Location = new System.Drawing.Point(90, 399);
            this.tbPrivateKeyB.Name = "tbPrivateKeyB";
            this.tbPrivateKeyB.Size = new System.Drawing.Size(100, 20);
            this.tbPrivateKeyB.TabIndex = 1;
            // 
            // lbPrivateKeyB
            // 
            this.lbPrivateKeyB.AutoSize = true;
            this.lbPrivateKeyB.Location = new System.Drawing.Point(12, 402);
            this.lbPrivateKeyB.Name = "lbPrivateKeyB";
            this.lbPrivateKeyB.Size = new System.Drawing.Size(71, 13);
            this.lbPrivateKeyB.TabIndex = 2;
            this.lbPrivateKeyB.Text = "PrivateKey-B:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 438);
            this.Controls.Add(this.lbPrivateKeyB);
            this.Controls.Add(this.tbPrivateKeyB);
            this.Controls.Add(this.lblog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lblog;
		private System.Windows.Forms.TextBox tbPrivateKeyB;
		private System.Windows.Forms.Label lbPrivateKeyB;
	}
}

