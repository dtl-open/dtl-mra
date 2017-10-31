using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTL.MRA.Customers.API.Data;
using DTL.MRA.Customers.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DTL.MRA.Customers.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/customers
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _unitOfWork.Customers.GetAll();

            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            if (customer == null || !TryValidateModel(customer))
            {
                return BadRequest();
            }

            _unitOfWork.Customers.Add(new Customer
            {
                Address = customer.Address,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber
            });

            var complete = _unitOfWork.Complete();

            return Ok(complete);
        }
    }
}
