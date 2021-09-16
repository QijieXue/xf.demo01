using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xf.demo01.ViewModels;
using xf.demo01.Views;

namespace xf.demo01
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
