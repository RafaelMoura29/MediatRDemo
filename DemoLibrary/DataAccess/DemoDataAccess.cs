using DemoLibrary.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDemoDataAccess
    {
        private List<PersonModel> People = new();

        public DemoDataAccess()
        {
            People.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            People.Add(new PersonModel { Id = 2, FirstName = "Sue", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return People;
        }

        public PersonModel InserPerson(string firstName, string lastname)
        {
            PersonModel person = new() { Id = People.Max(x => x.Id) + 1, FirstName = firstName, LastName = lastname };
            People.Add(person);
            return person;
        }
    }
}
