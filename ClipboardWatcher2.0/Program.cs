using Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var icon = new NotifyIcon();

            string resource1 = "ClipboardWatcher.Bunifu_UI_v1.5.3.dll";
            EmbeddedAssembly.Load(resource1, "Bunifu_UI_v1.5.3.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            using (Mutex mutex = new Mutex(false, "Global\\" + "ClipboardWatcher"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    //one instance of remindme already running          

                    icon.ShowBalloonTip(1000, "Balloon title", "Balloon text", ToolTipIcon.None);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                Application.Run(new MainForm());
            }

        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }


        //All uncaught exceptions will go here instead. We will replace the default windows popup with our own custom one and filter out what kind of exception is being thrown
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            ErrorPrompt p = new ErrorPrompt(e.Exception); p.Show();

            if (e.Exception is SettingsException)
            {
                SettingsException ex = (SettingsException)e.Exception;
                BLIO.WriteError(e.Exception, ex.Message + "\r\n" + ex.Description);                
            }
            else if (e.Exception is DirectoryNotFoundException)
            {
                DirectoryNotFoundException theException = (DirectoryNotFoundException)e.Exception;
                BLIO.WriteError(theException, "Folder not found.");
                
            }

            else if (e.Exception is UnauthorizedAccessException)
            {
                UnauthorizedAccessException theException = (UnauthorizedAccessException)e.Exception;
                BLIO.WriteError(e.Exception, "Unauthorized!");                
            }

            //Here we just filter out some type of exceptions and give different messages, at the bottom is the super Exception, which can be anything.              
            else if (e.Exception is FileNotFoundException)
            {
                FileNotFoundException theException = (FileNotFoundException)e.Exception; //needs in instance to call .FileName
                BLIO.WriteError(theException, "Could not find the file located at \"" + theException.FileName);                
            }

            else if (e.Exception is System.Data.Entity.Core.EntityException)
            {
                BLIO.WriteError(e.Exception, "System.Data.Entity.Core.EntityException");                
            }

            else if (e.Exception is ArgumentNullException)
            {
                BLIO.WriteError(e.Exception, "Null argument");                
            }

            else if (e.Exception is NullReferenceException)
            {
                BLIO.WriteError(e.Exception, "Null reference");                
            }

            else if (e.Exception is SQLiteException)
            {
                BLIO.WriteError(e.Exception, "SQLite Database exception");                
            }

            else if (e.Exception is PathTooLongException)
            {
                BLIO.WriteError(e.Exception, "The path to the file is too long.");                
            }

            else if (e.Exception is StackOverflowException)
            {
                BLIO.WriteError(e.Exception, "StackOverFlowException");                
            }

            else if (e.Exception is OutOfMemoryException)
            {
                BLIO.WriteError(e.Exception, "Out of Memory");                
            }
            else if (e.Exception is DbUpdateConcurrencyException)
            {
                BLIO.WriteError(e.Exception, "Database error.");                
            }

            else if (e.Exception is Exception)
            {
                BLIO.WriteError(e.Exception, "Unknown exception in main.");                
            }

        }
    }
}
