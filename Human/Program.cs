using System;

namespace Human
{

    // Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
    public class Human
    {

        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;

        // Add an additional private field for health (int), and a public property to access or "get" health
        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
        public int Attack(Human target)
        {
            int Damage = this.Strength * 5;
            target.Health -= Damage;
            return target.Health;
        }
 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human first = new Human("John");
            Console.WriteLine($"{first.Name}, {first.Strength}, {first.Intelligence}, {first.Dexterity}, {first.Health}");
            Human second = new Human("John", 10, 9, 10, 200);
            Console.WriteLine($"{second.Name}, {second.Strength}, {second.Intelligence}, {second.Dexterity}, {second.Health}");
            Console.WriteLine(first.Attack(second));

        }
    }
}
