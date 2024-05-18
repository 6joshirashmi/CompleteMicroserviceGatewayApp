using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet("GetCustomerList")]
        public ActionResult GetCustomer()
        {
            List<CustomerModel> customerModel = new List<CustomerModel> {
           new CustomerModel{ CustomerName = "ram",
            Id = 1},
         new CustomerModel{ CustomerName = "sita",
            Id = 2}
             };
            return Ok(customerModel);
        }
        [HttpPost("SaveCustomer")]
        public ActionResult SaveCustomer(CustomerModel customerModel)
        {
            return Ok("1");
        }
    }
}