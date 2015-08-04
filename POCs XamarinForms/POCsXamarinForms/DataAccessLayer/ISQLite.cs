using System;
using SQLite;

namespace POCsXamarinForms
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

