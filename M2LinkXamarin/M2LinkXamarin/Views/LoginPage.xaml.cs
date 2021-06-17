using M2LinkXamarin.WebServiceClients;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace M2LinkXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, EventArgs e)
        {
            if (Pseudo.Text != null && Password.Text != null && Pseudo.Text.Length > 0 && Password.Text.Length > 0)
            {
                User user = WSHelper.WSUserClient.Validate(Pseudo.Text, Password.Text);
                if (user != null)
                {
                    App.IsUserLoggedIn = true;
                    Application.Current.Properties["id"] = user.Id;
                    Application.Current.MainPage = new HomePage();
                }
                else
                {
                    messageLabel.Text = "Pseudo ou mot de passe incorrect";
                    Password.Text = string.Empty;
                }
            }
            else
            {
                messageLabel.Text = "Les champs sont obligatoires !";
            }
        }

        private async void Button_Register(object sender, EventArgs e)
        {
            var Email = EmailRegister.Text;
            var Lastname = LastnameRegister.Text;
            var Firstname = FirstnameRegister.Text;
            var Pseudo = PseudoRegister.Text;
            var Password = PasswordRegister.Text;
            var ConfirmationPassword = ConfirmationPasswordRegister.Text;

            if (Email != null && Lastname != null && Firstname != null && Pseudo != null && Password != null && ConfirmationPasswordRegister.Text != null
                && EmailRegister.Text.Length > 0 && LastnameRegister.Text.Length > 0 && FirstnameRegister.Text.Length > 0
                 && PseudoRegister.Text.Length > 0 && PasswordRegister.Text.Length > 0 && ConfirmationPasswordRegister.Text.Length > 0)
            {
                if (!WSHelper.WSUserClient.VerifyExistPseudo(Pseudo))
                {
                    Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.Compiled);
                    if (regexEmail.IsMatch(Email))
                    {
                        if (Password == ConfirmationPassword)
                        {

                            Regex regexMdp = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=/{};:<>|./?,-]).{8,}$", RegexOptions.Compiled);
                            if (Password.Length >= 8 && regexMdp.IsMatch(Password))
                            {
                                messageLabelRegister.Text = "";
                                byte[] hashMdp = System.Text.Encoding.ASCII.GetBytes(Password);
                                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                                string hash = BitConverter.ToString(sha.ComputeHash(hashMdp)).Replace("-", "");

                                var user = new User
                                {
                                    Id = Guid.NewGuid(),
                                    Nom = Lastname,
                                    Prenom = Firstname,
                                    Pseudo = Pseudo,
                                    Email = Email,
                                    Mdp = hash
                                };
                                WSHelper.WSUserClient.AddUser(user);
                                await DisplayAlert("S'inscrire", "Un nouveau utilisateur a bien été enregistré", "Ok");
                                //await Navigation.PopModalAsync();
                                Application.Current.MainPage = new LoginPage();
                            }
                            else
                            {
                                messageLabelRegister.Text = "Les mots de passes ne répondent pas aux normes !";
                                PasswordRegister.Text = string.Empty;
                                ConfirmationPasswordRegister.Text = string.Empty;
                            }
                        }
                        else
                        {
                            messageLabelRegister.Text = "Les mots de passes ne sont pas identiques !";
                            PasswordRegister.Text = string.Empty;
                            ConfirmationPasswordRegister.Text = string.Empty;
                        }

                    }
                    else
                    {
                        messageLabelRegister.Text = "L'adresse mail est invalide !";
                        EmailRegister.Text = string.Empty;
                    }
                }
                else
                {
                    messageLabelRegister.Text = "Pseudo est déjà existant dans la base de données !";
                    PseudoRegister.Text = string.Empty;
                }
            }
            else
            {
                messageLabelRegister.Text = "Tous les champs sont obligatoires !";
            }

        }
    }
    
}