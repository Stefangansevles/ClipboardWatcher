using Database.Entity;
using System;
using System.Data.SQLite;
using System.Linq;

namespace Data_Access_Layer
{
    public class DLDatabase
    {
        private DLDatabase() { }

        //Path to the .db file
        private static readonly string DB_FILE = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ClipboardWatcher\\ClipboardWatcherDatabase.db";
           
        //The neccesary query to execute to create the table Settings
        private const string TABLE_SETTINGS = "CREATE TABLE [Settings] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [SaveRootFolder] text NULL, [SaveImagePath] text NULL, [SaveTextPath] text NULL, [StartOnWindows] bigint DEFAULT 1 NULL);";



        /// <summary>
        /// Creates the database with associated tables
        /// </summary>
        public static void CreateDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "data source = " + DB_FILE;
            conn.Open();
           
            SQLiteCommand tableSettings = new SQLiteCommand();
            tableSettings.CommandText = TABLE_SETTINGS;
            tableSettings.Connection = conn;          
            tableSettings.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

        }

        /// <summary>
        /// Checks wether the table x has column x
        /// </summary>
        /// <param name="columnName">The column you want to check on</param>
        /// <param name="table">The table you want to check on</param>
        /// <returns></returns>
        public static bool HasColumn(string columnName, string table)
        {
            using (Entities db = new Entities())
            {
                try
                {
                    var t = db.Database.SqlQuery<object>("SELECT " + columnName + " FROM " + table).ToList();
                    db.Dispose();
                    return true;
                }
                catch (SQLiteException ex)
                {
                    db.Dispose();
                    //if (ex.Message.ToLower().Contains("no such column"))
                    //{
                    return false;
                    //}                                        
                }
            }
        }

        /// <summary>
        /// Checks if the database has the given table
        /// </summary>
        /// <param name="table"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private static bool HasTable(string table, Entities db)
        {
            try
            {
                var result = db.Database.ExecuteSqlCommand("select * from " + table);
                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the user's .db file has all the tables from the database model.
        /// </summary>
        /// <returns></returns>
        public static bool HasAllTables()
        {
            using (Entities db = new Entities())
            {
                if (HasTable("Settings", db)/*&& <future tables>*/)
                    return true;
                else
                    return false;
            }

        }

        /// <summary>
        /// Checks if the user's .db file has all the columns from the database model.
        /// </summary>
        /// <returns></returns>
        public static bool HasAllColumns()
        {
            

            var settingNames = typeof(Settings).GetProperties().Select(property => property.Name).ToList();

            foreach (string columnName in settingNames)
            {
                if (!HasColumn(columnName, "Settings"))
                    return false; //aww damn! the user has an outdated .db file!                
            }           

            return true;
        }

        /// <summary>
        /// Inserts all missing tables into the user's .db file 
        /// </summary>
        public static void InsertMissingTables()
        {
            using (Entities db = new Entities())
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn.ConnectionString = "data source = " + DB_FILE;
                conn.Open();
                
                SQLiteCommand tableSettings = new SQLiteCommand();

                tableSettings.CommandText = TABLE_SETTINGS;                
                tableSettings.Connection = conn;
                
                if (!HasTable("Settings", db))
                    tableSettings.ExecuteNonQuery();


                conn.Close();
                conn.Dispose();
                db.Dispose();
            }
        }

        /// <summary>
        /// This method will insert every missing column for each table into the database. Will only be called if HasallColumns() returns false. This means the user has an outdated .db file
        /// </summary>
        public static void InsertNewColumns()
        {
            using (Entities db = new Entities())
            {
                //every column that SHOULD exist                
                var settingNames = typeof(Settings).GetProperties().Select(property => property.Name).ToArray();                          

                foreach (string column in settingNames)
                {
                    if (!HasColumn(column, "settings"))
                        db.Database.ExecuteSqlCommand("ALTER TABLE SETTINGS ADD COLUMN " + column + " " + GetSettingColumnSqlType(column));
                }

                db.SaveChanges();
                db.Dispose();
            }
        }

        /// <summary>
        /// Gets the SQLite data types of the settings columns, "text not null", "bigint null", etc
        /// </summary>
        /// <param name="columnName">The column you want to know the data type of</param>
        /// <returns>Data type of the column</returns>
        private static string GetSettingColumnSqlType(string columnName)
        {
            //Yes, this is not really the "correct" way of dealing with a problem, but after a lot of searching it's quite a struggle
            //to get the data types of the sqlite columns, especially when they're nullable.
            switch (columnName)
            {
                case "SaveRootFolder":
                case "SaveImagePath": 
                case "SaveTextPath": return "text NULL";
                case "StartOnWindows": return "bigint DEFAULT 1 NULL";                
                default: return "text NULL";
            }
        }
    }
}
