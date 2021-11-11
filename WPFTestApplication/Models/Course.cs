using System.Collections.ObjectModel;

namespace WPFTestApplication.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public ObservableCollection<Person> Participants { get; set; }
    }
}