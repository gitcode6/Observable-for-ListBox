using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public static class Sample
    {
        public static void AddPeople(BindingList<Person> people)
        {
            people.Add(new Person() { FirstName = "Tobias", LastName = "Lehner", Age = 17 });
            people.Add(new Person() { FirstName = "Alexander", LastName = "Schmidt", Age = 16 });
            people.Add(new Person() { FirstName = "Pia", LastName = "Kotzbek", Age = 16 });
        }
    }
}
