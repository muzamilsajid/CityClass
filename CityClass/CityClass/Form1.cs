using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityClass
{
    public partial class Form1 : Form
    {
        List<City> myListOfCities = new List<City>();
        List<Person> myListOfPeople = new List<Person>();
        City currentCity;
        Person currentPerson;
        City city;
        Person person;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddCity_Click(object sender, EventArgs e)
        {
            listBoxCities.Items.Clear();
            city = new City();

            city.CreateCity(txtCityName.Text);
            myListOfCities.Add(city);

            foreach (City cities in myListOfCities)
            {
                listBoxCities.Items.Add(cities.Name);
            }
        }

        private void ListBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            listCityDetails.Items.Clear();

            foreach (City cities in myListOfCities)
            {
                if(cities.Name == listBoxCities.SelectedItem.ToString())
                {
                    currentCity = cities;
                }
            }

            listCityDetails.Items.Add($"{currentCity.Name} | {currentCity.Population} | {currentCity.Area}");

            foreach (Person people in currentCity.ListOfPeople)
            {
                listCityDetails.Items.Add($"{people.FirstName} {people.LastName}");
            }
        }

        private void BtnChangeCityName_Click(object sender, EventArgs e)
        {
            currentCity.ChangeCityName(txtCityName.Text);

            listBoxCities.Items.Clear();

            foreach (City cities in myListOfCities)
            {
                listBoxCities.Items.Add(cities.Name);
            }
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            person = new Person();
            
            person.CreatePerson(txtFirstName.Text, txtLastName.Text, currentCity);

            myListOfPeople.Add(person);
            currentCity.ListOfPeople.Add(person);
        }
    }
}
