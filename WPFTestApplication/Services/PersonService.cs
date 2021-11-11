using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using WPFTestApplication.Data.Interfaces;
using WPFTestApplication.Messages;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    public class PersonService : ObservableObject, IPersonService
    {
        private readonly IMockedData mockedData;
        private Person currentPerson;

        public Person CurrentPerson
        {
            get => currentPerson ?? new Person();
            set
            {
                SetProperty(ref currentPerson, value);
                WeakReferenceMessenger.Default.Send(new PersonChangedMessage());
            }
        }

        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get => persons ?? new ObservableCollection<Person>();
            set => SetProperty(ref persons, value);
        }

        public ObservableCollection<Person> GetPersons()
        {
            Persons = mockedData.GetPersons();
            return Persons;
        }

        public PersonService(IMockedData mockedData)
        {
            this.mockedData = mockedData;
        }
    }
}