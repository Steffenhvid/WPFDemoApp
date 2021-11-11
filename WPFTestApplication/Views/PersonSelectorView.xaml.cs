using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using WPFTestApplication.Services;
using WPFTestApplication.ViewModels;

namespace WPFTestApplication.Views
{
    public partial class PersonSelectorView : UserControl
    {
        public PersonSelectorView()
        {
            this.DataContext = this.DataContext = new PersonSelectorViewModel(Ioc.Default.GetService<IPersonService>());
            InitializeComponent();
        }
    }
}