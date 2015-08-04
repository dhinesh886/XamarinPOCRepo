using System;
using SQLite;

namespace POCsXamarinForms
{
	public class UserProfile
	{
		public UserProfile ()
		{
			
		}
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string UserId { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public bool IsSuspended { get; set; }
	}
}

