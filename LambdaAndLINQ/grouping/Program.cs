using System;
using System.Collections.Generic;
using System.Linq;


namespace grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog { Name = "Rex", Age = 4, Color = "Brown", Address = "Varna"},
                new Dog { Name = "Sharo", Age = 0, Color = "Grey", Address = "Varna"},
                new Dog { Name = "Pesho", Age = 4, Color = "Gold", Address = "Varna"},
                new Dog { Name = "Gosho", Age = 3, Color = "blue", Address = "Varna"},
                new Dog { Name = "Lili", Age = 0, Color = "red", Address = "Varna"},
                new Dog { Name = "Penka", Age = 3, Color = "green", Address = "Varna"},
                new Dog { Name = "Kalin", Age = 4, Color = "pink", Address = "Varna"},
                new Dog { Name = "Ali", Age = 4, Color = "Gold", Address = "Varna"},
                new Dog { Name = "Sasho", Age = 3, Color = "Gold", Address = "Varna"},
                new Dog { Name = "Reni", Age = 0, Color = "Gold", Address = "Varna"},
                
            };

            //var groupedDogs = dogs.GroupBy(dogs => dogs.Age, dogs => dogs. Name);// you can use instead of dogs any other variable too

            ////foreach (IGrouping<int,string> group in groupedDogs )
            ////{
            ////    Console.WriteLine(group.Key);

            ////    foreach (var name in group)
            ////    {
            ////        Console.WriteLine("--" + name);
            ////    }
            ////}

            //Dictionary<int, List<string>> dictionary = groupedDogs.ToDictionary(g => g.Key, g => g.ToList());

            //foreach (var kvp in dictionary)
            //{
            //    Console.WriteLine(kvp.Key);

            //    foreach (var name in kvp.Value)
            //    {
            //        Console.WriteLine($"--{name}");
            //    }
            //}

            //Shorter way:

            var groupedDogs = dogs
                .GroupBy(d => d.Age, d => d.Name)
                .ToDictionary(d => d.Key, d => d.ToList());
            
            foreach (var kvp in groupedDogs)
            {
                Console.WriteLine(kvp.Key);

                foreach (var name in kvp.Value)
                {
                    Console.WriteLine($"--{name}");
               }
           }
        }
    }
}
