using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;

namespace WPFTestApplication.ViewModels
{
    public class OrderViewModel
    {


        #region Properties
        #region Private Properties

        #endregion
        #region Public Properties
        public ObservableCollection<ComboBox> Comboboxes = new ObservableCollection<ComboBox>();
        public List<string> ComboBoxItems { get; set; } = new List<string>();
        #endregion

        //For texts do not split private and public properties
        #region Text Properties
        public string Title { get; set; }
        #endregion
        #endregion

        #region Commands

        #endregion

        #region Constructors
        public OrderViewModel()
        {
            Title = "AwesomeTitle";
            ComboBoxItems.Add("Henning");
            ComboBoxItems.Add("Carsten");
            ComboBoxItems.Add("Bruno");
            CreateComboBox();

        }

        private void CreateComboBox()
        {
            Comboboxes.Add(new ComboBox() { ItemsSource = ComboBoxItems });
        }
        #endregion

        #region Model Initialization

        #endregion

        #region Methods
        #region Private Methods

        #endregion

        #region Publics Methods

        #endregion
        #endregion

    }
}
