using Data_Access_Layer;
using Database.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLSettings
    {
        public static Settings Settings
        {
            get { return DLSettings.Settings; }
            set
            {
                //Check if the paths are not null/empty
                if(value.SaveImagePath == null || value.SaveImagePath == String.Empty
                   || value.SaveRootFolder == null || value.SaveRootFolder == String.Empty
                   || value.SaveTextPath == null || value.SaveTextPath == String.Empty
                   || value.StartOnWindows == null || value.StartOnWindows < 0)
                {
                    throw new SettingsException("Invalid setting update modification","The set folder path was null or empty. Halting updating the database.");                    
                }

                DLSettings.Settings = value;
            }
        }
    }
}
