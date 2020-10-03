using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinStub.Views
{
  public partial class Login : ContentPage
  {
    public Login()
    {
      InitializeComponent();
    }

    async void redirectToLogin(System.Object sender, System.EventArgs e)
    {
      await Navigation.PushAsync(new Dashboard());

    }
    async void redirectToRegister(System.Object sender, System.EventArgs e)
    {
      await Navigation.PushAsync(new Register());

    }


    async void submitUsername(System.Object sender, System.EventArgs e)
    {
      String userName = userNameText.Text;
      String password = passwordText.Text;
      if (string.IsNullOrEmpty(userName))
      {
        await DisplayAlert("Input Error", "Please enter username or email", "OK");
      }if (string.IsNullOrEmpty(password))
      {
        await DisplayAlert("Input Error", "Please enter username or email", "OK");
      }
      else
      {
       
      }
    }

    async void forgotLoginidCall(System.Object sender, System.EventArgs e)
    {
       
    }
  }
}

