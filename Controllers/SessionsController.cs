using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class SessionsController : Controller
    {
        private readonly ApiOptions _options;

        public SessionsController(IOptions<ApiOptions> options)
        {
            _options = options.Value;
        }

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            var response = await client.GetStringAsync(_options.SessionsEndpoint);

            var sessions = JsonConvert.DeserializeObject<IEnumerable<SessionModel>>(response);

            return View(sessions);
        }
    }
}
