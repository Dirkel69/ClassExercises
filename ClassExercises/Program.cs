using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //For Bucket
        public static bool IsPossible(Bucket b1, Bucket b2) => b2.GetCapacity() >= b2.GetAmount() + b1.GetAmount();
    
        //
    }
    class Bucket
    {
        private string color;
        private int capacity;
        private int amount;
        public Bucket(int capacity) => (this.color, this.capacity, this.amount) = ("White", capacity, 0);
        public Bucket(string color) => (this.color, this.capacity, this.amount) = (color, 10, 0);
        public bool HasWater() => this.amount > 0;
        public void Change(int num, char op)
        {
            if (op == '+')
            {
                if (this.amount + num > this.capacity) { Console.WriteLine("Too much water for to complete the action."); return; }
                this.amount += num;
            }
            else if (op == '-')
            {
                if (this.amount - num < 0)
                {
                    Console.WriteLine("Not enough water to complete the action.");
                    return;
                }
                this.amount -= num;
            }
            else Console.WriteLine("What the hell is that goofy action you tried💀");
        }
        public int GetCapacity()=>  this.capacity;
        public int GetAmount() =>  this.amount;
    }
    class Device
    {
        string name;
        int ticketPrice, kidsAllowed, adultsAllowed, kids, adults;//kid: 15-     adult: 16+
        public Device(string n, int p, int a, int k) => (this.name, this.ticketPrice, this.kidsAllowed, this.adultsAllowed) = (n, p, k, a);
        public void Add(int age) { if (age >= 16 && this.adults < this.adultsAllowed) this.adults++;
            else if (this.kids < this.kidsAllowed) this.kids++;
            else Console.WriteLine("No more room for people of this age group.");
        }
    }
}
