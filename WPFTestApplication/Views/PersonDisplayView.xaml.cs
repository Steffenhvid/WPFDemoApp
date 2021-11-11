using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using WPFTestApplication.Services;
using WPFTestApplication.ViewModels;

namespace WPFTestApplication.Views
{
    public partial class PersonDisplayView : UserControl
    {
        public PersonDisplayView()
        {
            this.DataContext = new PersonDisplayViewModel(Ioc.Default.GetService<IPersonService>());
            InitializeComponent();
        }
    }
}