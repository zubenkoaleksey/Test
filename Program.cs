using System;
using System.Collections.Generic;


namespace ConsoleApplication3
{
    interface IJuiceable
    {
        string MakeJuice();
    }
    interface ISliceable
    {
        string MakeSlices();
    }

    public class Fruit : IJuiceable, ISliceable
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            if (name == "")
                Console.WriteLine("Unknown fruit");
            else
                Name = name;
        }
                
        public string MakeJuice()
        {
            return $"Juice from {Name}";
        }
        public string MakeSlices()
        {
            return $"Slices of {Name}";
        }
    }

    public class Fresh
    {
        List<string> juices = new List<string>();
        List<string> slices = new List<string>();

        public void AddToJuices(string juice)
        {
            juices.Add(juice);
        }
        public void AddToSlices(string sLices)
        {
            slices.Add(sLices);
        }

        public void MakeFresh()
        {
            juices.AddRange(slices);

            Console.WriteLine("\tTo make new fresh use\n");
            foreach (var fruit in juices)
            {
                Console.WriteLine(fruit);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fruit orange = new Fruit("orange");
            Fruit lemon = new Fruit("lemon");
            Fruit pineapple = new Fruit("pineapple");
            Fruit melon = new Fruit("melon");            
            Fruit coconut = new Fruit("coconut");

            var juice1 = orange.MakeJuice();
            var juice2 = lemon.MakeJuice();
            var juice3 = coconut.MakeJuice();
            var slice1 = pineapple.MakeSlices();
            var slice2 = melon.MakeSlices();

            Fresh fresh = new Fresh();
            fresh.AddToJuices(juice1);
            fresh.AddToJuices(juice2);
            fresh.AddToJuices(juice3);
            fresh.AddToSlices(slice1);
            fresh.AddToSlices(slice2);

            fresh.MakeFresh();

            Console.ReadKey();

        }
    }
}
