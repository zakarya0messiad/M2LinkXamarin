using M2LinkXamarin.Views;
using M2LinkXamarin.WebServiceClients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListUsersPage : ContentPage
    {
        public ObservableCollection<User> Items { get; set; }

        public ListUsersPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<User>();
            List<User> list = WSHelper.WSUserClient.GetListUser().ToList();

            foreach (User user in list)
            {
                Items.Add(user);
            }

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            User user = (User)e.Item;

            Guid id = (Guid)Application.Current.Properties["id"];
            if (user.Id == id)
            {
                await Navigation.PushAsync(new MyProfilPage());
            }
            else
            {
                await Navigation.PushModalAsync(new ProfilePage(user));
            }
            ((ListView)sender).SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Items = new ObservableCollection<User>();
            List<User> list = WSHelper.WSUserClient.GetListUser().ToList();

            foreach (User user in list)
            {
                Items.Add(user);
            }

            MyListView.ItemsSource = Items;
        }
    }
}
