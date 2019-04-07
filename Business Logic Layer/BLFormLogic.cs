using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class BLFormLogic
    {
        private BLFormLogic() { }

        public static void CopyListviewTextToClipboard(ListView lv)
        {
            if (lv.SelectedItems.Count == 0)
                return;

            var builder = new StringBuilder();
            foreach (ListViewItem item in lv.SelectedItems)
                builder.AppendLine(item.SubItems[0].Text );

            Clipboard.SetText(builder.ToString());
        }
    }
}
