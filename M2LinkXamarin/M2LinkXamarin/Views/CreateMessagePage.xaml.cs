using M2LinkXamarin.WebServiceClients;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateMessagePage : ContentPage
    {
        public CreateMessagePage()
        {
            InitializeComponent();
        }

        private async void Button_post_message(object sender, EventArgs e)
        {
            if (editor.Text != null && editor.Text.Length > 0)
            {
                messageLabel.Text = "";
                Guid id = (Guid)Application.Current.Properties["id"];
                User myUser = WSHelper.WSUserClient.GetUser(id);
                WSHelper.WSMessageClient.AddMessage(id, editor.Text, myUser.Pseudo);
                await DisplayAlert("Message", "Votre message a bien été enregistré", "OK");
                await Navigation.PopModalAsync();
            }
            else
            {
                messageLabel.Text = "Le message est vide !";
            }
        }
    }
}