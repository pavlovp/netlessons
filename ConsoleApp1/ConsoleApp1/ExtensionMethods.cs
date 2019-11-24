using System;
using System.Linq;

namespace Lab8_b
{
    public static class ExtensionMethods
    {
        public static bool CheckIfPowerOfTwo(this int num)
        {
            string binarnie = Convert.ToString(num, 2);
            var chars = binarnie.ToCharArray();
            int ileJed = chars.Where(x => x == '1').Count();
            return ileJed == 1;
        }
    }
}