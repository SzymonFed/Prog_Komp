using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Class1
    {
        public static string getPluginName()
        {
            return "s_Odwroc";
        }
        public static string s_Odwroc(string value)
        {
            return Reverse(value);
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
