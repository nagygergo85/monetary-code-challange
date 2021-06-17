using Microsoft.AspNetCore.Mvc;
using Monetary.Assessment;
using Monetary.Common.Interfaces;
using Monetary.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monetary.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonetaryController : ControllerBase
    {
       
        public readonly IAssessment _assessment;
        public MonetaryController(IAssessment assessment)
        {
            _assessment = assessment;
        }

        // POST api/<MonetaryController>
        [HttpPost]
        public ActionResult Post([FromBody] MonetaryInput input)
        {
            var output = _assessment.GetMonetaryAssessment(input);
            return Ok(output);
        }

    }
}
