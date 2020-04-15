using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class Translator
    {
        public string Translate(int num)
        {
            var romanNumeral = "";
            while (num > 0)
            {
                if (num >= 10)
                {
                    romanNumeral += "X";
                    num -= 10;
                }
                else if (num == 9)
                {
                    romanNumeral += "IX";
                    num -= 9;
                }
                else if (num >= 5)
                {
                    romanNumeral += "V";
                    num -= 5;

                }
                else if (num == 4)
                {
                    romanNumeral += "IV";
                    num -= 4;
                }
                // will keep adding I if num is still greater than or equal to 1
                else if (num >= 1)
                {
                    romanNumeral += "I";
                    num -= 1;
                }

            }
            return romanNumeral;
        }
    }
}
