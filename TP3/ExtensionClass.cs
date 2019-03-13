using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace TP3
{
    static class ExtensionClass
    {
        public static void WriteContent(this ArrayList theObject)
        {
            string result = "[";
            
            foreach (var elem in theObject)
            {
                if (theObject.IndexOf(elem) != 0)
                {
                    result += ",";
                }
                result += elem;
            }
            
            result += "]";
            Console.WriteLine( result );
        }
    }
}