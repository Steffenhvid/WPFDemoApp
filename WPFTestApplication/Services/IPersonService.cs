
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    public interface IPersonService
    {
        Person CurrentPerson { get; set; }
        ObservableCollection<Person> Persons { get; set; }

        ObservableCollection<Person> GetPersons();
    }
}