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
    public partial class MyProfilPage : ContentPage
    {
        public User MyProfil { get; set; }

        public MyProfilPage()
        {
            Guid id = (Guid)Application.Current.Properties["id"];
            MyProfil = WSHelper.WSUserClient.GetUser(id);
            BindingContext = this;
            InitializeComponent();
        }

        private async void Modify(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModifyProfilPage(MyProfil));
        }
    }
}