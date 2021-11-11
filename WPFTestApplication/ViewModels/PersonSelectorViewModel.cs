using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using WPFTestApplication.Models;
using WPFTestApplication.Services;

namespace WPFTestApplication.ViewModels
{
    public class PersonSelectorViewModel : ObservableObject
    {
        private readonly IPersonService personService;
        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get => persons;
            set => SetProperty(ref persons, value);
        }

        private Person currentPerson;

        public Person CurrentPerson
        {
            get => currentPerson;
            set
            {
                SetProperty(ref currentPerson, value);
                personService.CurrentPerson = value;
            }
        }

        public PersonSelectorViewModel(IPersonService personService)
        {
            this.personService = personService;
            InitializeModel();
        }

        private void InitializeModel()
        {
            persons = new ObservableCollection<Person>();
            persons = personService.GetPersons();
        }
    }
}