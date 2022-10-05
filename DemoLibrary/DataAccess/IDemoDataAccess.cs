using DemoLibrary.DataAccess.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDemoDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InserPerson(string firstName, string lastname);
    }
}