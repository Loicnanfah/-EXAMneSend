using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Text;

namespace ÔneSend.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertychanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        public async Task DisplayAlert(string titel,string message,string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(titel, message, cancel);
        }

        public async Task <bool> DisplayAlert(string titel, string message, string accept,string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(titel, message, accept, cancel);   
        }

        protected bool SetProperty <T>(ref T field,T value,[CallerMemberName]string propertName = null)
        {

        }
        
    }
}
