using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFTestApplication.Data;
using WPFTestApplication.Data.Interfaces;
using WPFTestApplication.Models;

namespace WPFTestApplication.ViewModels
{
    public class ComboBoxViewModel : ObservableObject
    {

        private readonly IMockedData mockedData;

        private ComboBoxDataModel currentItem;

        public ComboBoxDataModel CurrentItem
        {
            get => currentItem;
            set => SetProperty(ref currentItem, value);
        }

        private ObservableCollection<ComboBoxDataModel> comboBoxData;

        public ObservableCollection<ComboBoxDataModel> ComboBoxData
        {
            get => comboBoxData;
            set => SetProperty(ref comboBoxData, value);
        }


        private string selectedValue;

        public string SelectedValue
        {
            get => selectedValue;
            set => SetProperty(ref selectedValue, value);
        }

        public ComboBoxViewModel(IMockedData mockedData)
        {
            this.mockedData = mockedData;
            ComboBoxData = mockedData.GetComboBoxData();
        }

    }
}
