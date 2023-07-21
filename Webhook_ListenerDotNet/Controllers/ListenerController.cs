using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Webhook_ListenerDotNet.Controllers
{
    [ApiController]
    [Route("/api/listener")]
    public class ListenerController : Controller
    {
        /// <summary>
        /// This method to this specific route represents the actual listener. 
        /// Indeed, anyone who contacts this route in POST by sending the body, 
        /// this listener will listen and print the actual data.
        /// </summary>
        /// <returns>Ok if the data was correctly received and printed</returns>
        [HttpPost]
        public async Task<IActionResult> WebhookListener()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    string jsonText = await reader.ReadToEndAsync();
                    JObject jObject = JObject.Parse(jsonText);
                    Console.WriteLine(jObject);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Ok();
        }
    }
}
