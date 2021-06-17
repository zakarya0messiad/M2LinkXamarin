using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using M2LinkXamarin.WebServiceClients;

namespace M2LinkXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageDetail : ContentPage
    {
        public ObservableCollection<Message> Items { get; set; }
        public string NbFollow { get; }
        public string NbFollowers { get; }


        public HomePageDetail()
        {
            InitializeComponent();

            Items = new ObservableCollection<Message>();
            Guid id = (Guid)Application.Current.Properties["id"];
            List<Message> list = WSHelper.WSMessageClient.GetListMessagesFollow(id).ToList();


            foreach (Message message in list)
            {
                Items.Add(message);
            }

            MyListView.ItemsSource = Items;
            NbFollow = WSHelper.WSMessageClient.GetNbFollow(id).ToString();
            NbFollowers = WSHelper.WSUserClient.GetNbFollowers(id).ToString();
            BindingContext = this;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert(((Message)e.Item).OwnerPseudo, ((Message)e.Item).Content, "Retour");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}

