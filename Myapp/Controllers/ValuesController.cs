using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Myapp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Add a value.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /values
        ///     value=hoge
        /// 
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>A new value</returns>
        /// <response code="201">Returns the newly-created value</response>
        /// <response code="400">If the value is null</response>
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Get), 1);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
