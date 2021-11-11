using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using WPFTestApplication.Messages;
using WPFTestApplication.Models;
using WPFTestApplication.Services;

namespace WPFTestApplication.ViewModels
{
    public class PersonDisplayViewModel : ObservableObject
    {
        private readonly IPersonService personService;

        private Person currentPerson;

        public Person CurrentPerson
        {
            get => currentPerson ?? new Person();
            set => SetProperty(ref currentPerson, value);
        }

        private string someText;
        public string SomeText
        {
            get => someText ?? "Hest";
            set => SetProperty(ref someText, value);
        }

        public PersonDisplayViewModel(IPersonService personService)
        {
            this.personService = personService;
            InitializeModel();
            RegisterMessages();
            SomeText = "Hest";
        }

        private void RegisterMessages()
        {
            WeakReferenceMessenger.Default.Register<PersonChangedMessage>(this, (r,m) => CurrentPerson = personService.CurrentPerson);
        }

        private void InitializeModel()
        {
            CurrentPerson = personService.CurrentPerson;
        }
    }
}