using M2LinkXamarin.WebServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModifyProfilPage : ContentPage
    {
        public User MyProfil { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public string Pseudo { get; set; }

        public ModifyProfilPage(User user)
        {
            MyProfil = user;
            Nom = user.Nom;
            Prenom = user.Prenom;
            Email = user.Email;
            Pseudo = user.Pseudo;
            Mdp = string.Empty;
            BindingContext = this;
            InitializeComponent();
        }

        private async void Button_Modify(object sender, EventArgs e)
        {
            var EmailModify = EmailRegister.Text;
            var LastnameModify = LastnameRegister.Text;
            var FirstnameModify = FirstnameRegister.Text;
            var PseudoModify = PseudoRegister.Text;
            var PasswordModify = NewPasswordRegister.Text;

            //var CurrentPassword = CurrentPasswordRegister.Text;
            //var NewPassword = NewPasswordRegister.Text;
            var ConfirmationPassword = ConfirmationPasswordRegister.Text;

            if (EmailModify != null && LastnameModify != null && FirstnameModify != null && PseudoModify != null && PasswordModify != null && ConfirmationPassword != null
                && EmailModify.Length > 0 && LastnameModify.Length > 0 && FirstnameModify.Length > 0
                 && PseudoModify.Length > 0 && PasswordModify.Length > 0 && ConfirmationPassword.Length > 0)
            {
                if (PseudoModify == MyProfil.Pseudo || !WSHelper.WSUserClient.VerifyExistPseudo(PseudoModify))
                {
                    Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.Compiled);
                    if (regexEmail.IsMatch(EmailModify))
                    {


                        Regex regexPwd = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=/{};:<>|./?,-]).{8,}$", RegexOptions.Compiled);
                        if (PasswordModify.Length >= 8 && regexPwd.IsMatch(PasswordModify) && PasswordModify == ConfirmationPassword)
                        {
                            messageLabelRegister.Text = "";
                            Guid id = (Guid)Application.Current.Properties["id"];

                            byte[] hashMdp = Encoding.ASCII.GetBytes(PasswordModify);
                            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                            string hash = BitConverter.ToString(sha.ComputeHash(hashMdp)).Replace("-", "");

                            MyProfil.Nom = LastnameModify;
                            MyProfil.Prenom = FirstnameModify;
                            MyProfil.Pseudo = PseudoModify;
                            MyProfil.Email = EmailModify;
                            MyProfil.Mdp = hash;

                            WSHelper.WSUserClient.ModifyUser(MyProfil);
                            await DisplayAlert("Modification du compte", "La modification a bien été prise en compte", "Ok");
                            await Navigation.PopModalAsync();
                        }
                        else
                        {
                            messageLabelRegister.Text = "Le mots de passe est invalid !";
                            NewPasswordRegister.Text = string.Empty;
                            ConfirmationPasswordRegister.Text = string.Empty;
                        }

                    }
                    else
                    {
                        messageLabelRegister.Text = "L'e-mail est invalide !";
                        EmailRegister.Text = string.Empty;
                    }
                }
                else
                {
                    messageLabelRegister.Text = "Pseudo est déjà utilisé !";
                    PseudoRegister.Text = string.Empty;
                }
            }
            else
            {
                messageLabelRegister.Text = "Tous les champs sont obligatoires !";
                NewPasswordRegister.Text = string.Empty;
                ConfirmationPasswordRegister.Text = string.Empty;
            }
        }
    }
}