using ClipboardWatcher;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLIO
    {
        public static void WriteError(Exception ex, string message)
        {
            
        }
        public static void CreateDatabaseIfNotExist()
        {
            if (!System.IO.File.Exists(IOVariables.databaseFile))
                DLDatabase.CreateDatabase();
            else
            {
                //great! the .db file exists. Now lets check if the user's .db file is up-to-date. let's see if the reminder table has all the required columns.
                if (DLDatabase.HasAllTables())
                {
                    if (!DLDatabase.HasAllColumns())
                        DLDatabase.InsertNewColumns(); //not up to date. insert !
                }
                else
                {
                    DLDatabase.InsertMissingTables();
                    //re-run the method, since the .db file **should** now have all the tables.
                    CreateDatabaseIfNotExist();
                }

            }


        }
    }
}
