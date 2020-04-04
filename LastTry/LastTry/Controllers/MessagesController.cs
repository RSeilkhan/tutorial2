using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LastTry.Controllers
{
    /*    [Route("Say")]
        public class MessagesController : Controller
        {
            [Route("{**message}/{}")] //выдает ошибку что нельзя использовать {} в route, если их убрать то не работает
            public IActionResult ShowMessage(string message)
            {
                if (string.IsNullOrEmpty(message))
                {
                    ViewData["Message"] = "Message is empty";
                }
                else
                {
                    ViewData["Message"] = message;
                }

                return View();
            }
        }
    */
    public class MessagesController : Controller
    {
        public IActionResult ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                ViewData["Message"] = "Message is empty";
            }
            else
            {
                ViewData["Message"] = message;
            }

            return View();
        }
    }
}