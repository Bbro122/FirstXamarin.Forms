using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace First.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }
        public string AboutMe { get; set; } = "Hi! My name is Adam and this is my first project!";
        public ICommand OpenWebCommand { get; }
    }
}