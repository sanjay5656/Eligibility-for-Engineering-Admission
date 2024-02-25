using System;

namespace exp1
{
    class Eligibility
    {
        static void Main(string[] args)
        {
            string n;
            int m, p, c;
            Console.Write("Enter your name:");
            n = Console.ReadLine();
            Console.Write("Enter Maths Marks:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Marks:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks:");
            c = Convert.ToInt32(Console.ReadLine());
            int Sum = m + p + c;
            int tot = m + p;
            if (m >= 65 && p >= 55 && c >= 50)
            {
                if (Sum >= 180 || tot >= 140)
                {
                    Console.WriteLine(n + " is eligible for admission to an engineering course.");
                }
                else
                {
                    Console.WriteLine(n + " is not eligible for admission to an engineering course due to insufficient marks.");
                }
            }
            else
            {
                Console.WriteLine(n + " is not eligible for admission to an engineering course due to insufficient marks.");
            }
            Console.Read();
        }
    }
}
