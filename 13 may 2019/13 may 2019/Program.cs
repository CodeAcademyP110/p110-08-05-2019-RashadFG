using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    //class FirstTask
    //{
    //static void Main(string[] args)
    //    {
    //    Console.Write("eded daxil edin:");
    //    string distance = Console.ReadLine();
    //    int number = int.Parse(distance);
    //    int sum=0;

    //    for (int i = 1; i <= number; i++)
    //    {
    //        sum +=i;
    //    }
    //    Console.WriteLine(sum);
    //    }
    //}

    //class secondtask
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("eded daxil edin:");
    //        string distance = Console.ReadLine();
    //        int number = int.Parse(distance);
    //        int sum = 0;

    //        for (int i = 1; i < number; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                sum += i;
    //            }
    //        }
    //        Console.WriteLine(sum);
    //    }
    //}

    //class thirdtask
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("eded daxil edin:");
    //        string distance = Console.ReadLine();

    //        int sum = 0;
    //        for (int i = 0; i < distance.Length; i++)
    //        {
    //            int number = int.Parse(distance.Substring(i, 1));
    //            sum += number;
    //        }
    //        Console.WriteLine(sum);
    //    }
    //}

    class fourthtask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input your email");
            string email = Console.ReadLine();
            if (email.IndexOf('@') != -1)
            {
                Console.WriteLine("your input is true");
            }
            else
            {
                Console.WriteLine("your input is not true");
            }
        }
    }

}


