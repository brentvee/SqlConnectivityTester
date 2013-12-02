using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConnectivityTester
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			TestConnection();
		}

		private async void TestConnection()
		{
			txtLog.Text = "Testing Connection...";

			var connectionString = txtConnectionString.Text;
			Properties.Settings.Default.ConnectionString = connectionString;
			Properties.Settings.Default.Save();

			picStatus.Image = Properties.Resources.appbar_progress;
			btnTest.Enabled = false;
			

			var sct = new SqlConnectivityTester();

			var result = await sct.TestConnectionAsync(connectionString);

			if (result.IsValid)
			{
				picStatus.Image = Properties.Resources.appbar_check;
			}
			else
			{
				picStatus.Image = Properties.Resources.appbar_warning;
			}

			txtLog.Text = result.Message;

			btnTest.Enabled = true;
		}


	}
}
