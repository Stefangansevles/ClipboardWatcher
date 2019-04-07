using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardWatcher
{
    public class IOVariables
    {
        private IOVariables() { } // No reason to make an instance of this class
        /// <summary>
        /// Contains the userprofile of the user (C:\Users\[username]\)
        /// </summary>
        public static readonly string userProfile = System.Environment.GetEnvironmentVariable("USERPROFILE");

        /// <summary>
        /// Contains the path to the appdata folder of clipboardwatcher, which contains the database and errorlog
        /// </summary>
        public static readonly string clipboardWatcherLocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ClipboardWatcher";

        /// <summary>
        /// Contains the path to the SQLite Database of ClipboardWatcher
        /// </summary>
        public static readonly string databaseFile = clipboardWatcherLocalFolder + "\\ClipboardWatcherdatabase.db";

        /// <summary>
        /// Contains the path to the error log file of ClipboardWatcher. This contains exceptions and when they occured.
        /// </summary>
        public static readonly string errorLog = clipboardWatcherLocalFolder + "\\ErrorLog.txt";

        /// <summary>
        /// Contains the startup folder path. 
        /// </summary>
        public static readonly string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

        /// <summary>
        /// Contains the path to the root folder of RemindMe
        /// </summary>
        public static readonly string rootFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ClipboardWatcher\";

        /// <summary>
        /// Returns the version of ClipboardWatcher. Read from the assembly
        /// </summary>
        public static string ClipboardWatcherVersion
        {
            get
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileVersion;
            }
        }
    }
}
