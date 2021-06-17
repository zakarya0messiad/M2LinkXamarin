using M2LinkXamarin.WebServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public User profil { get; set; }
        public string FollowState { get; set; }
        private bool IsFollow;

        public ProfilePage(User user)
        {
            profil = user;
            Guid id = (Guid)Application.Current.Properties["id"];
            IsFollow = WSHelper.WSMessageClient.IsFollow(id, user.Id);
            FollowState = IsFollow ? "Ne plus suivre" : "Suivre";
            BindingContext = this;
            InitializeComponent();
        }

        private async void Button_follow(object sender, EventArgs e)
        {
            Guid id = (Guid)Application.Current.Properties["id"];
            if (IsFollow)
            {
                WSHelper.WSMessageClient.UnFollow(id, profil.Id);
            }
            else
            {
                WSHelper.WSMessageClient.Follow(id, profil.Id);
            }
            await Navigation.PopModalAsync();
        }
    }
}