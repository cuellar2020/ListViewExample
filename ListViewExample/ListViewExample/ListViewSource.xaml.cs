using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ListViewSource()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Maria Fabian "});
            employees.Add(new Employee { DisplayName = "Lara Shelman" });
            employees.Add(new Employee { DisplayName = "Richard Holsoon" });
            employees.Add(new Employee { DisplayName = "Zelan Hookthusn" });
            employees.Add(new Employee { DisplayName = "Liam Kilthums" });
        }
    }
}