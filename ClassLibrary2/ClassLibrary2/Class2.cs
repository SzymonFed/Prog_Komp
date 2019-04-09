using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClassLibrary2
{
    public class Class2
    {
        public static string getPluginName()
        {
            return "r_Kursywa";
        }
        
        public static void r_Kursywa(RichTextBox richBox)
        {
                System.Drawing.Font newFont, oldFont;
                oldFont = richBox.SelectionFont;
                if (oldFont.Italic)
                    newFont = new Font(oldFont, FontStyle.Regular);
                else
                    newFont = new Font(oldFont, FontStyle.Italic);
                richBox.Font = newFont;
        }
        
    }
}
