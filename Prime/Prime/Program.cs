using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        public void Prime(int num1, int num2)
        {
            int flag = 0;

            Console.WriteLine("Prime numbers between {0} and {1} are: ",num1,num2);

            for (int i = num1; i <= num2; i++)
            {
                if (i == 0 || i == 1)
                    continue;

                flag = 1;

                for(int j = 2; j <= i/2; j++)
                {
                    if(i%j==0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if(flag==1)
                    Console.WriteLine(i);
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int num1, num2;

            Console.WriteLine("Enter lower limit:");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter upper limit:");
            num2 = int.Parse(Console.ReadLine());

            program.Prime(num1, num2);

            Console.ReadKey();

            Console.WriteLine("Edit from Ujjawal");
        }
    }
}
