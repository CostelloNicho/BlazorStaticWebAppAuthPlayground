using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace BlazorApp.api
{
    public static class TestUserDataHeaders
    {
        [FunctionName("TestUserDataHeaders")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var userClaims = StaticWebAppsAuth.Parse(req);
            return new OkObjectResult(userClaims);
        }
    }
}