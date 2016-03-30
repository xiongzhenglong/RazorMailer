﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Sample.Core.Email.Models;
using Sample.Core.Email;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SampleMailer _sampleMailer;

        public HomeController(SampleMailer sampleMailer)
        {
            _sampleMailer = sampleMailer;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendWelcomeEmail(WelcomeModel model)
        {
            await _sampleMailer.SendWelcomeEmailAsync(model);

            return View("Index", model);
        }
    }
}