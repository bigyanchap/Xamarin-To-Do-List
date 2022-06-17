using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WakeMe.Services
{
    public class NavigationService:INavigationService
    {

        public async Task<Page> PopAsync()
        {
            return await Main_page.Navigation.PopAsync();
        }
        public async Task PushAsync(Page page)
        {
            await Main_page.Navigation.PushAsync(page);
        }
        public async Task PushModalAsync(Page page)
        {
            await Main_page.Navigation.PushModalAsync(page);
        }
        public Page Main_page
        {
            get
            {
                return Application.Current.MainPage;
            }
        }
    }
}
