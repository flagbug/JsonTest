using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JsonTest.Controllers
{
    public class Foo
    {
        public string Bar { get; set; }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(new Foo
            {
                Bar = "<!DOCTYPE html><html><body><p>This!</p><p visible-if=\"correct\">Not this!</p><code>var x = <br></code><p>Cool!</p></body></html>"
            });
        }
    }
}