using System.ComponentModel;
using Xamarin.Forms;
using xf.demo01.ViewModels;

namespace xf.demo01.Views
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