using System;
using Microsoft.AspNetCore.Mvc;

namespace QuickBuy.Web.Controllers
{
    [Route("api/Controller")]
    public class UsuarioController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}