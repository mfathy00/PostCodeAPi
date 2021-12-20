using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostCodeAPi.Response;
using PostCodeAPi.Services;
using System.Text.RegularExpressions;

namespace PostCodeAPi.Controllers
{
    public class PostCodeController : Controller
    {
        // GET: PostCodeController
        IPostCodeSearch postcode;

        PostCodeController(IPostCodeSearch code)
        {
            postcode = code;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostCodeController/Details/5
        public PostCodeViewcs Details(string postcodetest)
        {
            var regepattern = @"";
            var match = Regex.Match(postcodetest, regepattern);
            if (match.Success)
            {
                return postcode.test(postcodetest);

            }
            return postcode.test(postcodetest);

        }


        // GET: PostCodeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostCodeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostCodeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostCodeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
