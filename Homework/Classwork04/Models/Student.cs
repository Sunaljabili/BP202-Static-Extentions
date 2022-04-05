using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        private string _groupno;
        public string Fullname { get; set; }
        public string GroupNo { get { return _groupno; }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                }
            }
            }

        public int Age { get; set; }

        
        public static bool CheckGroupNo(string groupNo)
        {
            if(!string.IsNullOrEmpty(groupNo) && groupNo.Length == 4)
            {
                if (char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
                {
                    return true;
                }
            }return false;
        }

        //public static bool CheckFullname(string str)
        //{
        //    if (!string.IsNullOrWhiteSpace(str) && str.Contains(" "))
        //    {
        //        string[] fullnameStr = str.Split(" ");
        //        foreach (var word in fullnameStr)
        //        {
        //            if (!string.IsNullOrWhiteSpace(word) && char.IsUpper(word[0]))
        //            {
        //                for (int i = 1; i < word.Length; i++)
        //                {
        //                    if (!(char.IsLetter(word[i]) && char.IsLower(word[i])))
        //                        return false;
        //                }
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        public static bool CheckFullname( string str)
        {
            var result = str.Split(" ");
            if (result.Length == 2)
            {
                if (char.IsUpper(result[0][0]) && char.IsUpper((char)result[1][0]) &&
                    result[0].Length > 2 && result[1].Length > 2)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
