using Bogus;
using Bogus.DataSets;
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker("ru");
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(faker.Name.FullName()+" "+ faker.
                    Date.Past(32, new DateTime(2000, 12, 12)).ToShortDateString());
            }
            Console.ReadKey();
        }
    }
}
