using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello, extension Methods!";

            //Console.WriteLine(text.WordCount());

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

            //Console.WriteLine(string.Join(", ", evenNumbers));

            List<Dog> dogs = new List<Dog>()
            {
                new Dog { Name = "Rex", Age = 4, Color = "Brown", Address = "Ruse"},
                new Dog { Name = "Sharo", Age = 4, Color = "Grey", Address = "Sofia"},
                new Dog { Name = "Pesho", Age = 4, Color = "Gold", Address = "Varna"}
            };

            //var names = dogs.Select(d => d.Name);

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            var newDogList = dogs.Select(
                d => new { Age = d.Age, FirstLetter = d.Name[0] }
                );
            foreach (var newDog in newDogList)
            {
                Console.WriteLine(newDog);
            }
        }
    }

    //public static class StringExtensions
    //{
    //    public static int WordCount(this string str)
    //    {
    //        return str.Split(new char[] {' ', '.','!',';',':' },StringSplitOptions.RemoveEmptyEntries).Length;
    //    }
    //}
}
