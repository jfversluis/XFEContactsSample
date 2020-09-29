using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEContactsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var result = await Contacts.PickContactAsync();

            if (result != null)
                resultContact.Text = $"{result.Name} ({result.Numbers[0].PhoneNumber})";
        }
    }
}
