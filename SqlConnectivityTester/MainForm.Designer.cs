namespace SqlConnectivityTester
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.picStatus = new System.Windows.Forms.PictureBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(94, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Connection String";
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(94, 110);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(135, 23);
			this.btnTest.TabIndex = 2;
			this.btnTest.Text = "&Test Connection";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(94, 252);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// picStatus
			// 
			this.picStatus.Image = global::SqlConnectivityTester.Properties.Resources.appbar_database;
			this.picStatus.Location = new System.Drawing.Point(12, 28);
			this.picStatus.Name = "picStatus";
			this.picStatus.Size = new System.Drawing.Size(76, 76);
			this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picStatus.TabIndex = 4;
			this.picStatus.TabStop = false;
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.Location = new System.Drawing.Point(94, 183);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(505, 63);
			this.txtLog.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(91, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Result";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblInfo.Location = new System.Drawing.Point(9, 12);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(123, 13);
			this.lblInfo.TabIndex = 7;
			this.lblInfo.Text = "SQL Connectivity Tester";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(27, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 11);
			this.label3.TabIndex = 8;
			this.label3.Text = "Brent Vee";
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlConnectivityTester.Properties.Settings.Default, "ConnectionString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtConnectionString.Location = new System.Drawing.Point(94, 44);
			this.txtConnectionString.Multiline = true;
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(505, 60);
			this.txtConnectionString.TabIndex = 0;
			this.txtConnectionString.Text = global::SqlConnectivityTester.Properties.Settings.Default.ConnectionString;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnTest;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(611, 296);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.picStatus);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtConnectionString);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SQL Connectivity Tester";
			((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtConnectionString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox picStatus;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label label3;
	}
}

