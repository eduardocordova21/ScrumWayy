using ScrumWayy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScrumWayy.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}