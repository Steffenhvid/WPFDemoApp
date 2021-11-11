using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Data.Interfaces;
using WPFTestApplication.Models;

namespace WPFTestApplication.Data
{
    public class MockedData : IMockedData
    {
        private ObservableCollection<ComboBoxDataModel> ComboBoxData { get; set; }
        private ObservableCollection<Person> Persons { get; set; }
        private ObservableCollection<Person> Persons2 { get; set; }

        public MockedData()
        {
            CreateComboBoxData();
            CreatePersonData();
            CreatePersonData2();
        }

        private void CreatePersonData2()
        {
            Persons2 = new ObservableCollection<Person>();
            Person person1 = new Person() { Age = 5, Name = "Karina", NickName = "Thunder" };
            Person person2 = new Person() { Age = 6, Name = "Carina", NickName = "Lightning" };
            Person person3 = new Person() { Age = 7, Name = "Qarina", NickName = "Drizzle" };
            Persons2.Add(person1);
            Persons2.Add(person2);
            Persons2.Add(person3);
        }

        private void CreatePersonData()
        {
            Persons = new ObservableCollection<Person>();
            Person person1 = new Person() {Age = 5, Name = "Carsten", NickName = "Hurricane"};
            Person person2 = new Person() {Age = 6, Name = "Karsten", NickName = "Storm"};
            Person person3 = new Person() {Age = 7, Name = "Qarsten", NickName = "Breeze"};
            Persons.Add(person1);
            Persons.Add(person2);
            Persons.Add(person3);
        }





        public ObservableCollection<ComboBoxDataModel> GetComboBoxData()
        {
            return ComboBoxData;
        }

        public ObservableCollection<Person> GetPersons()
        {
            return Persons;
        }

        public ObservableCollection<Person> GetPersonsTwo()
        {
            return Persons2;
        }

        private void CreateComboBoxData()
        {
            ComboBoxData = new ObservableCollection<ComboBoxDataModel>()
            {
                new ComboBoxDataModel()
                {
                    Id = 1, PresentationName = "pName1", AccesName = "aName1",
                },
                new ComboBoxDataModel()
                {
                    Id = 2, PresentationName = "pName2", AccesName = "aName2",
                },
                new ComboBoxDataModel()
                {
                    Id = 3, PresentationName = "pName3", AccesName = "aName3",
                },
                new ComboBoxDataModel()
                {
                    Id = 4, PresentationName = "pName4", AccesName = "aName4",
                },
            };
        }

        
    }    
}
