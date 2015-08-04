using System;
using Xamarin.Forms;
using POCsXamarinForms.Droid;
using System.IO;

[assembly: Dependency (typeof (SQLite_Android))]

namespace POCsXamarinForms.Droid
{
	public class SQLite_Android
	{
		public SQLite_Android ()
		{
		}
		#region ISQLite implementation
		public SQLite.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "POCDB.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal); // Documents folder
			//var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine(documentsPath, sqliteFilename);
			var conn = new SQLite.SQLiteConnection(path);

			// Return the database connection 
			return conn;
		}
		#endregion
	}
}

