using Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DLSettings
    {
        //Don't allow a constructor. There's no need for this and it makes the syntax more sugary. DLSettings.Method()
        private DLSettings() { }

        private static Settings InsertDefaultSettings()
        {
            Settings setting = new Settings();
            setting.Id = 1;
            setting.SaveImagePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ClipboardWatcher output\\Images";
            setting.SaveRootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ClipboardWatcher";
            setting.SaveTextPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ClipboardWatcher output\\Text";
            setting.StartOnWindows = 1;
            Settings = setting;
            return setting;
        }
        /// <summary>
        /// Gets the settings from the database
        /// </summary>        
        /// <returns>The settings read from the database. Null if no settings record yet exist</returns>
        public static Settings Settings
        {            
            get
            {
                Settings setting = null;

                using (Entities db = new Entities())
                {
                    if (db.Settings.Count() > 0)
                    {
                        setting = (from g in db.Settings select g).Where(i => i.Id == 1).SingleOrDefault();


                        db.Dispose();

                        return setting;
                    }
                    else
                    {
                        //Nothing in the database yet                    
                        return InsertDefaultSettings();
                    }
                }
                                            
            }
            set
            {
                Settings setting = null;
                using (Entities db = new Entities())
                {
                    if (db.Settings.Count() > 0)
                    {
                        setting = (from g in db.Settings select g).Where(i => i.Id == 1).SingleOrDefault();

                        setting.SaveImagePath = value.SaveImagePath;
                        setting.SaveRootFolder = value.SaveRootFolder;
                        setting.SaveTextPath = value.SaveTextPath;
                        setting.StartOnWindows = value.StartOnWindows;

                        db.Settings.Attach(setting);
                        var entry = db.Entry(setting);
                        entry.State = System.Data.Entity.EntityState.Modified; //Mark it for update                                
                        db.SaveChanges();                                      //push to database
                        db.Dispose();                        
                    }
                    else
                    {//The settings table is still empty
                        db.Settings.Add(value);
                        db.SaveChanges();
                        db.Dispose();
                    }
                }
            }
        }
    }
}
