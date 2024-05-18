using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
         [HttpGet("GetProductList")]
        public ActionResult GetProduct()
        {
            List<ProductModel> productModel=new List<ProductModel>{
          new ProductModel{  Id=1,
        ProductName="Ice"},

 new ProductModel{  Id=2,
        ProductName="Ice bottel"}
        };
            return Ok(productModel);

        }
        [HttpPost("SaveProduct")]
         public ActionResult SaveProduct(ProductModel productModel)
        {productModel.Id=1;
        productModel.ProductName="Ice";
            return Ok(productModel);

        }
    }
}