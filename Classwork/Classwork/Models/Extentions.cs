using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static  class Extentions
    {
        #region Task-1
        public static bool Isprime(this int num)
        {

            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false ;
                }
            }
            return true;
        }
        #endregion

        #region Task-2
        public static bool IsPowOfTwo(this int num)
        {
            if (num % 2 == 0)
            {
                for (int i = 2; i <= num; i *= 2)
                {
                    if (i == num)
                        return true;
                }
            }
            return false;
        }
        #endregion

        #region Task-3
        public static bool CustomContains(this string pattern, string str)
        {
            string[] newArr = pattern.Trim().Split(' ');
            for (int i = 0; i < newArr.Length; i++)
            {
                if (str==newArr[i])
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Task-4
        public static bool CustomContains(this string pattern, char chr)
        {
            foreach (var item in pattern)
            {
                if (item == chr)
                    return true;
            }
            return false;
        }

        #endregion

    }
}
