using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json;
using WeDoCurrency.Model;

namespace WeDoCurrency.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {
		Currency curObject;
		public ValuesController()
		{
			try
			{
				WebClient request = new WebClient();
				var url = "https://api.fixer.io/latest?base=DKK";
				var response = request.DownloadString(url);

				curObject = JsonConvert.DeserializeObject<Currency>(response);
			}
			catch (Exception e)
			{
				string error = "Error" + e;

				GetFallBackExchangeRate();
				
			}
			
		}

		//
        // GET api/values
        [HttpGet]
        [Route("GetExchangeRates")]
        public Currency GetExchangeRates()
        {
			//Logger.generateEventLog(curObject);

			return curObject;
        }

		// GET api/fallback
		
		public string GetFallBackExchangeRate()
		{

			WebClient request = new WebClient();
			var url = "http://openexchangerates.org/latest.json";
			var response = request.DownloadString(url);

			//curObject = JsonConvert.DeserializeObject<Currency>(response);


			return response;
		}
        /* GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
        }*/
    }
}
