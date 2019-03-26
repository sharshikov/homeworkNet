using Bogus;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var modelFaker = new Faker<MyModel>("en").
             RuleFor(o => o.Name, f => f.Name.FirstName()).
             RuleFor(o => o.SurName, f => f.Name.LastName()).
             RuleFor(o => o.Born, f => f.Date.Past(34,new DateTime(1990,12,4)));
            for (int i = 0; i < 10000; i++)
            {
                var myModel = modelFaker.Generate();
                Console.WriteLine(myModel.Name + " " + myModel.SurName + " " + myModel.Born.ToShortDateString());
            }
            Console.ReadKey();
        }
    }

    class MyModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Born { get; set; }
    }
}
