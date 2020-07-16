using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolymorphism
{
    public class Horse : Animal 
    {
        public string Name { get; set; }
        public Horse()
        {
            Name = "White Knight";
            Console.WriteLine(Name);
        }
        
        
        public override void Sound()
        {
            Console.WriteLine("Child class called. ");
        }
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Sound();
            Console.ReadLine();
        }
    }
}
