using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class StudentController : Controller
    {
        [Authorize]
        public IActionResult All()
        {
            return View();
        }
    }
}
