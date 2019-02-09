using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "UDDDUDUUDUDU";

            int altitude = 0;
            int count = 0;

            foreach (var item in path)
            {
                if (item == 'U')
                {
                    altitude++;
                    if (altitude == 0)
                    {
                        count++;
                    }
                }
                else
                {
                    altitude--;
                }

            }

            Console.WriteLine(count);

        }
    }
}
