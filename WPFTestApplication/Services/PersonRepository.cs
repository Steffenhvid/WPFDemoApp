using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Enums;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    internal class PersonRepository : IPersonRepository
    {
        private readonly Func<string, IPersonService> personService;
        private readonly string personSource;

        public PersonRepository(Func<string, IPersonService> personService, string personSource)
        {
            this.personService = personService;
            this.personSource = personSource;
        }

        public Person CurrentPerson
        {
            get
            {
                return personService(personSource).CurrentPerson;
            }
            set
            {
                personService(personSource).CurrentPerson = value;
            }
        }
        public ObservableCollection<Person> Persons
        {
            get
            {
                return personService(personSource).Persons;
            }

            set
            {
                personService(personSource).Persons = value;
            }
        }

        public ObservableCollection<Person> GetPersons()
        {
            return personService(personSource).GetPersons();
        }
    }
}
