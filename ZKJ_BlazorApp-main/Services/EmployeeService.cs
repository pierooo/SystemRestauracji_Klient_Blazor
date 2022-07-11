using BlazorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IHttpService _httpService;

        public EmployeeService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _httpService.Get<IEnumerable<Employee>>("/employees");
        }
    }
}