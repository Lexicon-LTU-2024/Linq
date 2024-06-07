using System;
using System.Threading.Channels;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();
           // persons.ForEach(p => Do(p));

            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }

            var p2 = persons.ToArray();

            var res = p2.OurersWhere<Person>(IsOver30);
            var res3 = p2.OurersWhere<Person>(p =>  IsOver30(p));
            var res2 = p2.Where(p => p.Age > 30);


            var res4 = p2.Where(p => p.Name == "Nisse")
                         .Select(p => new PersonDto{FirstName = p.Name,NamesLength = p.Name.Length})
                         .ToList();

            Console.WriteLine(res4[0].NamesLength);
            res4.ForEach(p => Console.WriteLine(p.FirstName));



        }

        private static bool IsOver30(Person p)
        {
            return p.Age > 30;
        }

        private static List<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
