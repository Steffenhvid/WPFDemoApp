using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    internal interface IPersonRepository
    {
        Person CurrentPerson { get; set; }
        ObservableCollection<Person> Persons { get; set; }

        ObservableCollection<Person> GetPersons();
    }
}
