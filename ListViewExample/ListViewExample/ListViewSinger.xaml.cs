using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSinger : ContentPage
    {
        ObservableCollection<Singer> singers= new ObservableCollection<Singer>();
        public ListViewSinger()
        {
            InitializeComponent();
            SingerView.ItemsSource = singers;
            singers.Add(new Singer ("Adam Levine", "Sugar" ));
            singers.Add(new Singer("Doja Cat", "Need to Know"));
            singers.Add(new Singer("Bruno Mars", "24K"));
            singers.Add(new Singer("Avril Lavigne", "Complicated"));
        }
    }
}