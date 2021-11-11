using System.Collections.ObjectModel;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    public interface ICourseService
    {
        ObservableCollection<Course> Courses { get; set; }
        
    }
}