using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Animal
    {
        public Animal(string name, int age)
        {
            this.Name = name;
            this.AgeInHumanYears = age;
        }
        //constructor for the class

        public int AgeInHumanYears { get; set; }
        public string Name { get; set; }
        public bool IsMicrochipped { get; set; }
        //three attributes of the class

    }
}
