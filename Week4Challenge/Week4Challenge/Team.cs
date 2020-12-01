using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenge
{

    abstract class Departments
    {

        public int Size { get; set; }
        public string Manager { get; set; }
        public string Name { get; set; }

        public int Drinks { get; set;  }
        public int GetDrinks(int Size) => Size * 2;

        public abstract int Getbudget();

    }

    class Group : Departments
    {

        public Group(int size, string manager, string name)
        {
            this.Size = size;
            this.Manager = manager;
            this.Name = name;
            this.Drinks = GetDrinks(this.Size);

        }

        public override int Getbudget() => Size * 50005;

    }

    class Team : Departments
    {

                public Team(int size, string manager, string name)
        {
            this.Size = size;
            this.Manager = manager;
            this.Name = name;
            this.Drinks = GetDrinks(this.Size);

        }

        public override int Getbudget() => Size * 50000;



        static void Main(string[] args)
        {
            int numberofDrinks;
            Team Training = new Team(7, "Bobby Sue", "Training");
            Team Dev = new Team(20, "Erik Baugues", "Development");

            Group HR = new Group(50, "Salle Mae", "Human Resources");
            Group IT = new Group(100, "Jim Goecks", "Information Technologies");

            numberofDrinks = HR.GetDrinks(HR.Size);
            Console.Write($"Get {HR.Name}, {numberofDrinks} drinks.\n");

            numberofDrinks = IT.GetDrinks(IT.Size);
            Console.Write($"Get {IT.Name}, {numberofDrinks} drinks.\n");
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();



        }
    }
}
