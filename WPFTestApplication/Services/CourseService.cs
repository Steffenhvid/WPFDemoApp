using System.Collections.ObjectModel;
using WPFTestApplication.Models;

namespace WPFTestApplication.Services
{
    public class CourseService : ICourseService
    {
        public ObservableCollection<Course> Courses { get; set; }
    }
}