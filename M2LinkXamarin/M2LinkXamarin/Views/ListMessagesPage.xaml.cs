
using M2LinkXamarin.WebServiceClients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListMessagesPage : ContentPage
    {
        public ObservableCollection<Message> Items { get; set; }

        public ListMessagesPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Message>();
            Guid id = (Guid)Application.Current.Properties["id"];
            List<Message> list = WSHelper.WSMessageClient.GetListMyMessages(id).ToList();


            foreach (Message message in list)
            {
                Items.Add(message);
            }
            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert(((Message)e.Item).PostDate.ToString(), ((Message)e.Item).Content, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async void AddMessage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateMessagePage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Items = new ObservableCollection<Message>();
            Guid id = (Guid)Application.Current.Properties["id"];
            List<Message> list = WSHelper.WSMessageClient.GetListMyMessages(id).ToList();

            foreach (Message message in list)
            {
                Items.Add(message);
            }
            MyListView.ItemsSource = Items;
        }


    }
}
