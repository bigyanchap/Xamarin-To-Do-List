using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WakeMe.Services
{
    public interface INavigationService
    {
        Task<Page> PopAsync();
        Task PushAsync(Page page);
        Task PushModalAsync(Page page);
    }
}