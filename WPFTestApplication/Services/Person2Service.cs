using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Data.Interfaces;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    internal class Person2Service : ObservableObject, IPersonService
    {
        private readonly IMockedData mockedData;
        private Person currentPerson;

        public Person CurrentPerson
        {
            get => currentPerson ?? new Person();
            set
            {
                SetProperty(ref currentPerson, value);
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
            Persons = mockedData.GetPersonsTwo();
            return Persons;
        }

        public Person2Service(IMockedData mockedData)
        {
            this.mockedData = mockedData;
        }
    }
}
