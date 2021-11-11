using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Models;

namespace WPFTestApplication.Data.Interfaces
{
    public interface IMockedData
    {
        ObservableCollection<ComboBoxDataModel> GetComboBoxData();
        ObservableCollection<Person> GetPersons();

        ObservableCollection<Person> GetPersonsTwo();

    }
}
