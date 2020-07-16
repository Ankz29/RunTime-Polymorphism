using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunTimePolymorphism;

namespace RunTimePolymorphism
{
    public class Animal 
    {
        public string Types { get; set; }
        public Animal()
        {
            Types = "Domestic Animals";
        }
        public virtual void Sound()
        {
            Console.WriteLine("Parent Class called. ");
        }
    }
}
