using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinStub.Views
{
  public partial class Register : ContentPage
  {
    public Register()
    {
      InitializeComponent();
    }



    async public void registerUser(object sender, EventArgs e)
    {
      String firstNameText = firstName.Text;
      String lastNameText = lastName.Text;
      String emailText = email.Text;
      String mobileText = mobile.Text;


      if (string.IsNullOrEmpty(firstNameText))
      {
        await DisplayAlert("Input Error", "Please enter first name", "OK");
      }
      else if (string.IsNullOrEmpty(lastNameText))
      {
        await DisplayAlert("Input Error", "Please enter last name", "OK");
      }
      else if (string.IsNullOrEmpty(emailText))
      {
        await DisplayAlert("Input Error", "Please enter email address", "OK");
      }
      else if (string.IsNullOrEmpty(mobileText))
      {
        await DisplayAlert("Input Error", "Please enter mobile number", "OK");
      }
      
      else
      {
      
      }

    }

    void OnCheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
    {
      bool check = e.Value;
      if (check)
      {
      
      }
      else
      {
      
      }
    }

    private async void Cancel_ClickedAsync(object sender, System.EventArgs e)
    {
      await Navigation.PopToRootAsync();
      
    }
  }
}
