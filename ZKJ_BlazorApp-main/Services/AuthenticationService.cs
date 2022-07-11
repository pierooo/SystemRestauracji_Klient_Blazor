using BlazorApp.Helpers;
using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public Employee Employee { get; private set; }

        public AuthenticationService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            Employee = await _localStorageService.GetItem<Employee>("employee");
        }

        public async Task Login(string username, string password)
        {
            
            Employee = await _httpService.Post<Employee>("/Employees/authenticate", new { username, password });
            Employee.AuthData = $"{username}:{password}".EncodeBase64();
            await _localStorageService.SetItem("employee", Employee);
        }

        public async Task Logout()
        {
            var emp = Employee;
            Employee = null;
            await _localStorageService.RemoveItem("employee");
            _navigationManager.NavigateTo("login");
        }
    }
}