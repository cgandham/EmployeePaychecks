using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewDetails.Utils;

namespace viewDetails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public EmployeeController()
        {
            _httpClient = new HttpClient();
        }

        //[HttpGet(Name = "GetEmployeeDetails")]
        //public async Task<IActionResult> GetEmployees()
        //{
        //    string url = "http://localhost:8080/user/getAll";
        //    HttpResponseMessage response = await _httpClient.GetAsync(url);
        //    string responseBody = await response.Content.ReadAsStringAsync();
        //    return Ok(responseBody);
        //}

        [HttpGet(Name = "GetEmployeeDetails")]
        public async Task<IActionResult> GetEmployeesPaychecks()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Constants.GET_EMPLOYEES_PAYCHECKS_URL);
            string responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
        }
    }
}

