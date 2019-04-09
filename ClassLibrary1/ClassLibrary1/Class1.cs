using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string getPluginName()
        {
            return "r_Pogrubienie";
        }
        public static void r_Pogrubienie(RichTextBox richBox)
        {
            System.Drawing.Font newFont, oldFont;
            oldFont = richBox.SelectionFont;
            if (oldFont.Bold)
                newFont = new Font(oldFont, FontStyle.Regular);
            else
                newFont = new Font(oldFont, FontStyle.Bold);
            richBox.Font = newFont;
        }
    }
}
