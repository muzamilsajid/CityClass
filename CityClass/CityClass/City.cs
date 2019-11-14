using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityClass
{
    class City
    {

        public List<Person> ListOfPeople = new List<Person>();

        private string name;
        public string Name
        {
            get { return name; }
        }

        private int population;
        public int Population
        {
            get { return population; }
        }

        private float area;
        public float Area
        {
            get { return area; }
        }

        public void CreateCity(string cName)
        {
            name = cName;
            //population = 2;
            area = new Random().Next(1000, 1000000);
        }

        public void ChangeCityName(string cName)
        {
            name = cName;
        }

        public void inCreasePopulation(int incPop)
        {
            population += incPop;
        }
    }
}
