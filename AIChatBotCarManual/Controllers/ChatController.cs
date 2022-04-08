using Microsoft.AspNetCore.Mvc;

namespace AIChatBotCarManual.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
