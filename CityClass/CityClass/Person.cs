using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClass
{
    class Person
    {
        private City currentlyincity;

        public City CurrentlyInCity
        {
            get { return currentlyincity; }
        }

        private string firstname;
        public string FirstName
        {
            get { return firstname; }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
        }

        private int age;
        public int Age
        {
            get { return age; }
        }

        public string fullName
        {
            get { return (firstname + " " + lastname); }
        }

        public void CreatePerson(string fName, string lName,City currentCity)
        {
            firstname = fName;
            lastname = lName;
            age = new Random().Next(15, 40);
            currentlyincity = currentCity;
        }
    }
}
