using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CMB.BaseConversion
{
    class BaseConversion
    {
        /// <summary>Converts a number from one base to another.</summary>
        public string Convert(string num, int fromRadix, int toRadix)
        {
            // Check if the number is negative
            bool isNegative = num.Contains("-");

            if (isNegative)
                num = num.Remove(0, 1);
            
            // Under these conditions, nothing changes
            if (Double.TryParse(num, out double dbl) && (dbl == 0.0 || dbl == 1.0) || fromRadix == toRadix)
                return isNegative ? num.Insert(0, "-") : num;

            // Convert our number to a workable decimal format
            num = ToDecimal(num, fromRadix);

            // If we're converting to decimal, all done
            if (toRadix == 10)
                return isNegative ? num.Insert(0, "-") : num;

            // Convert to the desired base
            num = ToBaseN(num, toRadix);
            
            // Return the result
            return isNegative ? num.Insert(0, "-") : num;
        }

        /// <summary>Converts a number to decimal.</summary>
        private string ToDecimal(string num, int rad)
        {
            // Skip if already decimal
            if (rad == 10)
                return num;

            // Split number into integral and fractional parts
            SplitNumber(num, out string numIntegral, out string numFractional);

            // Request indexed symbols
            char[] charPool = RequestBaseNSymbols(rad);

            // Convert integral part
            double resInteger = 0.0;

            if (numIntegral != "0" && !(numIntegral == "Z" && rad == 26))
            {
                numIntegral = numIntegral.Reverse();
                
                for (int i = 0; i < numIntegral.Length; i++)
                {
                    resInteger += Array.IndexOf(charPool, numIntegral[i]) * Math.Pow(rad, i);
                }
            }

            // Convert fractional part
            double resFraction = 0.0;

            if (numFractional != String.Empty)
            {
                for (int i = 0; i < numFractional.Length; i++)
                {
                    resFraction += Array.IndexOf(charPool, numFractional[i]) / Math.Pow(rad, i + 1);
                }
            }

            return (resInteger + resFraction).ToString();
        }

        /// <summary>Converts a number to base-N.</summary>
        private string ToBaseN(string num, int rad)
        {
            // Split number into integral and fractional parts
            SplitNumber(num, out string strIntegral, out string strFractional);

            // Convert integral part
            int numIntegral = Int32.Parse(strIntegral);
            List<int> resIntegral = new List<int>();

            do
            {
                resIntegral.Add(numIntegral % rad);
                numIntegral /= rad;
            }
            while (numIntegral > 0);
            
            resIntegral.Reverse();

            // Convert fractional part
            double? numFractional = null;
            List<int> resFractional = new List<int>();

            if (strFractional != String.Empty)
            {
                numFractional = Double.Parse(String.Format("0.{0}", strFractional));

                while (numFractional > 0)
                {
                    int n = (int)(numFractional *= rad);
                    resFractional.Add(n);
                    numFractional -= n;
                }
            }

            // Assemble and send it on its way
            char[] charPool = RequestBaseNSymbols(rad);
            StringBuilder sb = new StringBuilder();

            foreach (int i in resIntegral)
            {
                sb.Append(charPool[i]);
            }

            if (numFractional.HasValue)
            {
                sb.Append(".");

                foreach (int i in resFractional)
                {
                    sb.Append(charPool[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>Splits a number into integral and fractional parts.</summary>
        private void SplitNumber(string num, out string numIntegral, out string numFractional)
        {
            string[] nums = num.Split('.');
            bool isInteger = nums.Length == 1;

            numIntegral = nums[0];
            numFractional = isInteger ? String.Empty : nums[1];
        }

        /// <summary>Validates user input.<summary>
        public bool IsValidInput(string num, int rad)
        {
            // Request valid symbols for specified radix
            char[] validChars = RequestBaseNSymbols(rad);
            
            // Make sure each symbol in the number is valid for the specified radix
            foreach (char c in num)
            {
                if (c == '-' || c == '.')   // Negative sign & decimal point valid despite not being in validChars: skip
                    continue;               // RegEx will guard against having more than one
                
                if (Array.IndexOf(validChars, c) == -1)   // If current symbol is not found
                    return false;                         // in validChars, number is invalid
            }
            
            // Alpha-numerical sequence with optional negative sign / decimal part
            Regex numberFormat = new Regex(@"^-?[A-Z\d]+(\.[A-Z\d]+)?$");
            
            return numberFormat.IsMatch(num);
        }

        /// <summary>Generates an indexed list of symbols for a base numeral system.</summary>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public char[] RequestBaseNSymbols(int rad)
        {
            // User input is checked by WinForms, invalid radix here means something is wrong!
            if (!IsValidRadix(rad))
            {
                throw new ArgumentOutOfRangeException("Invalid radix passed to RequestBaseNSymbols()");
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

        /// <summary>Checks the validity of a radix.</summary>
        private bool IsValidRadix(int rad)
        {
            return (rad < 2 || rad > 36) ? false : true;
        }   
    }

    static class StringExtensions
    {
        /// <summary>Reverses a string.</summary>
        public static string Reverse(this string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}
