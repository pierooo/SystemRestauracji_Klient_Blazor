namespace BlazorApp.Services
{
    using System.Threading.Tasks;
    using BlazorApp.Models;

    public interface IAuthenticationService
    {
        Employee Employee { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
    }
}