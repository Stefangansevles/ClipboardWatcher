using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class SettingsException : Exception
    {
        private string description;
        public SettingsException(string title,string description) : base(title)
        {
            this.description = description;
        }
        public string Description
        {
            get { return description; }
        }
    }
}
