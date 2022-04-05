using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork04
{ 
    static class Extentions
    {
        public static bool IsOdd(this int number)
        {
            if (number%2==1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }



        public static bool isDigit(this string word)
        {
            foreach (var item in word)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }


        public static string ToCapitalize(this string word)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(word[0]));
            //sb.Append(word.Substring(1));
            for (int i = 1; i < word.Length; i++)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
            //return word;
        }
        //version1.1
        //public static int[] GetValueIndexes(this string word , char c)
        //{
        //    int[] indexes = new int[0];

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == c)
        //        {
        //            Array.Resize(ref indexes, indexes.Length + 1);
        //            indexes[indexes.Length - 1] = i;

        //        }
        //    }
        //    return indexes;
        //}

        //version1.2
        public static int[] GetValueIndexes(this string str, char letter)
        {
            int[] indexes = new int[0];
            if (!string.IsNullOrWhiteSpace(str))
            {
                while (str.Contains(letter))
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = str.LastIndexOf(letter);
                    str = str.Substring(0, str.LastIndexOf(letter));
                }
            }
            Array.Reverse(indexes);
            return indexes;
        }
    }
}
