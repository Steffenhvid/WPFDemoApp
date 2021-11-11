using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Models;
using WPFTestApplication.Services;

namespace WPFTestApplication.ViewModels
{
    public class ListViewHolderViewModel : ObservableObject
    {
        private readonly IPersonService personService;

        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get => persons ?? new ObservableCollection<Person>();
            set => SetProperty(ref persons, value);
        }

        public ListViewHolderViewModel(IPersonService personService)
        {
            this.personService = personService;
            initializeModel();
        }

        private void initializeModel()
        {
            persons = new ObservableCollection<Person>();
            persons = personService.GetPersons();
        }
    }
}
