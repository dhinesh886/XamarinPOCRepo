﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace POCsXamarinForms
{
	public class POCDB
	{

		static object locker = new object ();

		SQLiteConnection database;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		public POCDB()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			// create the tables
			database.CreateTable<TodoItem>();
			database.CreateTable<UserProfile>();
		}

		public IEnumerable<UserProfile> GetUserProfiles ()
		{
			lock (locker) {
				return (from i in database.Table<UserProfile>() select i).ToList();
			}
		}
		public UserProfile AuthenticateUser (string userId, string password) 
		{
			lock (locker) {
				return database.Table<UserProfile>().FirstOrDefault(x => x.UserId == userId && x.Password == password);
			}
		}
		public UserProfile GetUserProfile (int id) 
		{
			lock (locker) {
				return database.Table<UserProfile>().FirstOrDefault(x => x.ID == id );
			}
		}

		public int SaveUserProfile(UserProfile item) 
		{
			lock (locker) {
				if (item.ID != 0) {
					database.Update(item);
					return item.ID;
				} else {
					return database.Insert(item);
				}
			}
		}

		public int DeleteUserProfile(int id)
		{
			lock (locker) {
				return database.Delete<UserProfile>(id);
			}
		}


		public IEnumerable<TodoItem> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<TodoItem>() select i).ToList();
			}
		}

		public IEnumerable<TodoItem> GetItemsNotDone ()
		{
			lock (locker) {
				return database.Query<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
			}
		}

		public TodoItem GetItem (int id) 
		{
			lock (locker) {
				return database.Table<TodoItem>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int SaveItem (TodoItem item) 
		{
			lock (locker) {
				if (item.ID != 0) {
					database.Update(item);
					return item.ID;
				} else {
					return database.Insert(item);
				}
			}
		}

		public int DeleteItem(int id)
		{
			lock (locker) {
				return database.Delete<TodoItem>(id);
			}
		}
	}
}


