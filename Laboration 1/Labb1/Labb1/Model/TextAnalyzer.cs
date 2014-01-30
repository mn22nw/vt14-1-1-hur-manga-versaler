using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb1.Model
{
    public static class TextAnalyzer
    {
        static public int GetNumberOfCapitals(string text)
        {

            int upperCase = 0;

            foreach (char c in text)
            {

                if (Char.IsUpper(c))

                    upperCase += 1;
            }
            Console.WriteLine(upperCase);
            return upperCase;
        }
    }
}