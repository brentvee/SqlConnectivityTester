/*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*\
  Inivit Systems ©
  File Name: SqlConnectivityTester.cs
  Author:    Brent van der Merwe
  Date:      2013-12-02 
  Purpose:	
    
  Updates:

	Reviews
\*____________________________________________________________________________*/


using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlConnectivityTester
{
	public class SqlConnectivityTester
	{
		public async Task<SqlConnectionResult> TestConnectionAsync(string connectionString)
		{
			return await Task.Run(() => TestConnection(connectionString));
		}

		public SqlConnectionResult TestConnection(string connectionString)
		{
			var result = new SqlConnectionResult();
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					connection.Close();
				}

				result.IsValid = true;
				result.Message = "Success";
			}
			catch (Exception e)
			{
				result.IsValid = false;
				result.Message = e.Message;
			}

			return result;
		}
	}

	public class SqlConnectionResult
	{
		public string Message { get; set; }
		public bool IsValid { get; set; }
	}
}
