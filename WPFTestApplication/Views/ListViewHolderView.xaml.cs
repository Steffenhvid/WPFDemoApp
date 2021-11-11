using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTestApplication.Services;
using WPFTestApplication.ViewModels;

namespace WPFTestApplication.Views
{
    /// <summary>
    /// Interaction logic for ListViewHolderView.xaml
    /// </summary>
    public partial class ListViewHolderView : UserControl
    {
        public ListViewHolderView()
        {
            DataContext = new ListViewHolderViewModel(Ioc.Default.GetService<IPersonService>());
            InitializeComponent();
        }
    }
}
