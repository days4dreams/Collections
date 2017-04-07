using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Person laurenWilson = new Person("Lauren", "Wilson", 21, 160);
            Person stuartNairn = new Person("Stuart", "Nairn", 30, 180);
            Person ianSanderson = new Person("Ian", "Sanderson", 77, 175);
            Person xanaMillard = new Person("Xana", "Millard", 35, 165);
            //create four new person objects using the Person class

            List<Person> peopleOnOurCourse = new List<Person>();
            //Often we want to work with multiple objects of the same type (for example: customers or bank accounts).
            //Collections offer a way of storing a set of the same object together.
            //Don’t need to specify a capacity, you can add or remove items indefinitely.

            peopleOnOurCourse.Add(laurenWilson);
            peopleOnOurCourse.Add(stuartNairn);
            peopleOnOurCourse.Add(ianSanderson);
            peopleOnOurCourse.Add(xanaMillard);
            //we can use the function add to a list, here we add new people to the collection of peopleOnOurCourse

            Person daveMawer = new Person("Dave", "Mawer", 45, 1.85);
            Animal woofie = new Animal("Woofie", 7);
            daveMawer.Pets.Add(woofie);
            //create a new Person object, and then a new Animal object
            //add the woofie object to the list object in the Person class attributes

            List<Animal> clowder = new List<Animal>();
            //create a new collection, add some cats to clowder collection

            foreach (Animal cat in clowder)
            {
                //.. do stuff
            }
            //example foreach loop, using collection

            foreach (Animal cat in clowder)
            {
                if (cat.AgeInHumanYears < 10)
                {
                    //..do stuff
                }
            }
            //example if statement in loop

            foreach (Animal cat in clowder)
            {
                while (cat.AgeInHumanYears < 10)
                {
                    cat.AgeInHumanYears++;
                }
            }
            //example while in loop





        }
    }
}
