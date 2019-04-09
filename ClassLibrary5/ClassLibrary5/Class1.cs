using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class Class5
    {
        public static string getPluginName()
        {
            return "e_Powieksz";
        }
        public static string e_Powieksz(string value)
        {
            bool isUp = false;
            if (!isUp)
            {
                isUp = true;
                return value.ToUpper();

            }
            else
            {
                isUp = false;
                return value.ToLower();
            }
        }
    }
}
