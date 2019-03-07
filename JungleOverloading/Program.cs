using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new company
            var jungleBoogie = new Company("Jungle Boogie");

            //Instantiate some new employees
            var bagheera = new Employee("Bagheera", "Pantherson");
            var sherekhan = new Employee("Shere Kahn", "Lionson");
            var kaa = new Employee("Kaa", "Snakerson");
            var baloo = new Employee("Baloo", "Bearperson");

            //Add these employees to the list
            jungleBoogie.addNewEmployee(bagheera);
            jungleBoogie.addNewEmployee(sherekhan);
            jungleBoogie.addNewEmployee(kaa);
            jungleBoogie.addNewEmployee(baloo);

            //Baloo goes out to lunch
            baloo.eat();
            baloo.eat("fish");
            baloo.eat(jungleBoogie.jungleBoogie);
            baloo.eat("soup", jungleBoogie.jungleBoogie);

            Console.ReadKey();
        }
    }
}
