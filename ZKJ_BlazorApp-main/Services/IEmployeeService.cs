namespace BlazorApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BlazorApp.Models;

    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
    }
}