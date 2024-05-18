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
        [HttpGet("GetProductList")]
        public ActionResult GetCustomer()
        {
            return Ok("1");
        }
        [HttpPost("SaveProduct")]
        public ActionResult SaveCustomer(CustomerModel customerModel)
        { customerModel.CustomerName="ram";
        customerModel.Id=1;
            return Ok(customerModel);
        }
    }
}