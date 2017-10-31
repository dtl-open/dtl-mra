using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DTL.MRA.MeterReads.API.Data;
using DTL.MRA.MeterReads.API.Models;

namespace DTL.MRA.MeterReads.API.Controllers
{
    [Route("api/[controller]")]
    public class MeterReadsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MeterReadsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/customers
        [HttpGet]
        public IActionResult Get()
        {
            var meterReads = _unitOfWork.MeterReads.GetAll();

            return Ok(meterReads);
        }

        [HttpPost]
        public IActionResult Post([FromBody] MeterRead meterRead)
        {
            if (meterRead == null || !TryValidateModel(meterRead))
            {
                return BadRequest();
            }

            _unitOfWork.MeterReads.Add(new MeterRead
            {
                ReadingTime = meterRead.ReadingTime,
                MeterNumber = meterRead.MeterNumber,
                Provider = meterRead.Provider,
                Reading = meterRead.Reading
            });

            var complete = _unitOfWork.Complete();

            return Ok(complete);
        }
    }
}