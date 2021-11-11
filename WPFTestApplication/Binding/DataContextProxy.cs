using System.Windows;

namespace WPFTestApplication.Binding
{
    public class DataContextProxy : Freezable
    {
        /// This Class makes it possible to get properties from model in deeper datacontexts
        protected override Freezable CreateInstanceCore()
        {
            return new DataContextProxy();
        }

        public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
            "DataSource", typeof(object), typeof(DataContextProxy), new UIPropertyMetadata(null));



        public object DataSource
        {
            get { return GetValue(DataSourceProperty); }

            set
            {
                SetValue(DataSourceProperty, value);
            }
        }
    }
}
