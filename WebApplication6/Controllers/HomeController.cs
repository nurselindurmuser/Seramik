using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Product> productRepository;
        private IRepository<Contact> contactRepository;

        public HomeController(IRepository<Product> productRepository, IRepository<Contact> contactRepository)
        {
            this.productRepository = productRepository;
            this.contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {

            var contact = new Contact();
            return View(contact);
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contactRepository.Insert(contact);
                contactRepository.Update(contact);
                return RedirectToAction("Contact");
            }

            return View(contact);
        }
    
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Product()
        {
            var product = productRepository.GetAll();
            return View(product);
        }

        
        public IActionResult SSS()
        {
            return View();
        }
    }
}
