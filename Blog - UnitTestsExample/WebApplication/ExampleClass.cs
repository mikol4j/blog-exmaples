using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication;

namespace WebApplication
{
    public static class ExampleClass
    {
        public static bool IsCapitalized(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException(word);

            }
            if (Char.IsUpper(word[0]))
            {
                return true;
            }
            return false;
        }
    }
}
