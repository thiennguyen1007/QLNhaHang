using RestaurantApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Services
{

    public class UserService
    {
        private List<Person> dsPerson = new List<Person>()
        {
            new Person{ Name="Thien",DateOfBirth="0", DateOrder="0" ,SDT="000"}
        };

        public List<Person> DsPerson { get => dsPerson; set => dsPerson = value; }
        public Person GetPerson(string personSDT)
        {
            return dsPerson.SingleOrDefault(u => u.SDT == personSDT);
        }
    }
}
