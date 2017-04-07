using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Person
    {
        string _firstName = string.Empty;
        string _surname = string.Empty;
        int _age = 0;
        double _height = 0;
        //declare four variables used within the class

        public Person(string firstname, string surname, int age, double height)
        {
            _firstName = firstname;
            _surname = surname;
            _age = age;
            _height = height;
        }
        //create a constructor for the class, which indicates that objects belonging to the Person class
        //must include firstname surname age and height

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        //declare four attributes of Person class

        List<Animal> _pets = new List<Animal>();
        //create a list 
        
        public List<Animal> Pets
        {
            get { return _pets; }
            set { _pets = value; }
        }
        //declare fifth attribute, allowing objects of Person class to contain a list of Pets
    }
}
