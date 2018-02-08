using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMB.BaseConversion
{
    class BaseConversion
    {
        // Validate User Input
        public bool IsValidInput(string num, int rad)
        {
            // Request valid symbols for specified radix
            char[] validChars = RequestCharPool(rad);
            
            // Make sure each symbol in the number is valid for the specified radix
            foreach (char c in num)
            {
                if (c == '.')   // Decimal point valid despite not being in validChars: skip
                    continue;   // RegEx will guard against having more than one
                
                if (Array.IndexOf(validChars, c) == -1)   // If current symbol is not found
                    return false;                         // in validChars, number is invalid
            }
            
            // Alpha-numerical sequence with an optional decimal part
            Regex numberFormat = new Regex(@"^[A-Z\d]+(\.[A-Z\d]+)?$");
            
            return numberFormat.IsMatch(num);
        }

        // Generate an Indexed List of Symbols for Each Base Numeral System
        private char[] RequestCharPool(int rad)
        {
            // User input is checked by WinForms, invalid radix here means something is wrong!
            if (!IsValidRadix(rad))
            {
                throw new ArgumentOutOfRangeException("Invalid radix passed to RequestCharPool()");
            }

            // Create the array containing all symbols
            int unicodeOffset09 = 48, unicodeOffsetAZ = 65;
            IEnumerable<int> numRange = Enumerable.Range(unicodeOffset09, 10);      // 0-9 (10 Total)
            IEnumerable<int> abcRange = Enumerable.Range(unicodeOffsetAZ, 26);      // A-Z (26 Total)

            char[] charPool = numRange.Concat(abcRange).Select(x => (char)x).ToArray();

            // Return a corresponding set of symbols
            if (rad == 26)
            {
                charPool[9] = 'Z';
                return charPool.Skip(9).Take(26).ToArray();
            }
            else
            {
                return charPool.Take(rad).ToArray();
            }
        }

        // Check Validity of Radix
        private bool IsValidRadix(int rad)
        {
            return (rad < 2 || rad > 36) ? false : true;
        }
    }
}
