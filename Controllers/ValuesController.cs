using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace dotnet_multilang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiControllerBase
    {
        
        public ValuesController(IHtmlLocalizer<ValuesController> localizer)
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            _localizer = localizer.WithCulture(Thread.CurrentThread.CurrentUICulture);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var valor = _localizer["ContactPage"].Value;
            //var valor = _localizer.GetString("ContactPage").Value;
            return new string[] { valor };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
