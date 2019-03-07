using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        static List<string> restaurantList = new List<string>
        {
            "Rainforest Cafe",
            "Jungle To Table",
            "Jumanji Hut",
            "Baloo's Garden",
            "By The Rivers Of Corcovado"
        };

        public string randomRestaurant()
        {
            var random = new Random();
            int index = random.Next(restaurantList.Count);
            string restaurant = restaurantList[index];
            return restaurant;
        }

        public void eat()
        {
            Console.WriteLine($"{FirstName} is at {randomRestaurant()}.");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office.");
        }

        public void eat(List<Employee> jungleBros)
        {
            string myBros = "";
            foreach (var bro in jungleBros)
            {
                if (bro.FirstName != $"{FirstName}")
                {
                    myBros += bro.FirstName + ", ";
                }
            }
            string myFinalBros = myBros.Remove(myBros.Length - 2);
            Console.WriteLine($"{FirstName} is at {randomRestaurant()} with {myFinalBros}.");
        }

        public void eat(string food, List<Employee> jungleBros)
        {
            string myBros = "";
            foreach (var bro in jungleBros) 
            {
                if (bro.FirstName != $"{FirstName}")
                {
                    myBros += bro.FirstName + ", ";
                }
            }
            string myFinalBros = myBros.Remove(myBros.Length - 2);
            Console.WriteLine($"{FirstName} ate {food} at {randomRestaurant()} with {myFinalBros}.");
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
