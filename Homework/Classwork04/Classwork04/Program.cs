using System;
using Models;

namespace Classwork04
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number = 16;
            ////Console.WriteLine(number.IsOdd());
            ////Console.WriteLine(number.IsEven());
            //string test = "salam gencler necesiz?";

            ////Console.WriteLine(test.isDigit());
            ////Console.WriteLine(test.ToCapitalize());
            ////Console.WriteLine(test.ToCapitalize());

            //string word = "Salam";

            //foreach (var item in word.GetValueIndexes('a'))
            //{
            //    Console.WriteLine(item);
            //}

            Student student = new Student();
            string fullname = "Sugra  Ali";
            Console.WriteLine(Student.CheckFullname(fullname));
        }
    }
}
