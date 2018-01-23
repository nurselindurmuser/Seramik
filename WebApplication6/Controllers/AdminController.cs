using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    public class AdminController : Controller
    {
        private IRepository<Product> productRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public AdminController(IRepository<Product> productRepository, IHostingEnvironment hostingEnvironment)
        {
            this.productRepository = productRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        //ÜRÜNLERİ SIRALA
        public IActionResult Index()
        {
            
                var product = productRepository.GetAll();
                return View(product);           
        }

        //YENİ ÜRÜN EKLEME FORMUNU GÖRÜNTÜLER 
        public IActionResult Create()
        {
            var product = new Product();
            return View(product);
        }

        //YENİ ÜRÜN EKLER        
        [HttpPost]
        //image upload için "IFormFile upload" parametresini yazdık 
        public async Task<IActionResult> Create(Product product, IFormFile upload)
        {
            //dosya uzantısı için geçerlilik denetimi
            if (upload != null && !IsExtensionValid(upload))
            {
                ModelState.AddModelError("Photo", "Dosya uzantısı jpg, jpg, gif, png olmalıdır.");
            }
            else if (upload == null && product.Photo == null) //eğer resim yüklemeyi zorunlu yapmak istemiyorsanız bu else if'i kaldırmanız gerekiyor.
            {
                ModelState.AddModelError("Photo", "Resim yüklemeniz gerekmektedir.");
            }
            if (ModelState.IsValid)
            {
                //dosya yüklemesi
                string fileName = await UploadFileAsync(upload);
                if (fileName != null)
                {
                    product.Photo = fileName;
                }

                productRepository.Insert(product);
                productRepository.Update(product);
                return RedirectToAction("Index");
            }
            
            return View(product);
        }
        
        //BİR ÜRÜNÜ DÜZENLEMEK ÜZERE FORMU GETİRİR
        public IActionResult Edit(string id)
        {
            var product = productRepository.Get(p => p.Id == id);
            return View(product);
        }

        //EKLİ ÜRÜNÜ DÜZENLER
        [HttpPost]
        //image upload için "IFormFile upload" parametresini yazdık 
        public async Task<IActionResult> Edit(Product product, IFormFile upload)
        {
            //dosya uzantısı için geçerlilik denetimi
            if (upload != null && !IsExtensionValid(upload))
            {
                ModelState.AddModelError("Photo", "Dosya uzantısı jpg, jpg, gif, png olmalıdır.");
            }
            else if (upload == null && product.Photo == null) //eğer resim yüklemeyi zorunlu yapmak istemiyorsanız bu else if'i kaldırmanız gerekiyor.
            {
                ModelState.AddModelError("Photo", "Resim yüklemeniz gerekmektedir.");
            }

            if (ModelState.IsValid)
            {
                //dosya yüklemesi
                string fileName = await UploadFileAsync(upload);
                if (fileName != null)
                {
                    product.Photo = fileName;
                }
                productRepository.Update(product);          
                //var p = productRepository.Get(product.Id);
                //productRepository.Update(p);                
                //p.Title = product.Title;
                //p.Photo = product.Photo;
                //p.Detail = product.Detail;
                //p.UsageArea = product.UsageArea;
                //p.Size = product.Size;
                //p.Color = product.Color;
                //p.Date = product.Date;
                //productRepository.Update(p);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //BELİRTİLEN ID'Lİ ÜRÜNÜ SİLER
        public IActionResult Delete(string id)
        {
            var product = productRepository.GetMany(p => p.Id == id).FirstOrDefault();
            productRepository.Delete(product);
            return RedirectToAction("Index");
        }
        //upload edilecek dosyanın uzantısı geçerli mi? 
        private bool IsExtensionValid(IFormFile upload)
        {
            if (upload != null)
            {
                var allowedExtensions = new string[] { ".jpg", ".jpeg", ".gif", ".png" };
                var extension = Path.GetExtension(upload.FileName).ToLowerInvariant();
                return allowedExtensions.Contains(extension);
            }
            return false;
        }
        private async Task<string> UploadFileAsync(IFormFile upload)
        {
            //imgae upload için dosya yüklemesi
            if (upload != null && upload.Length > 0 && IsExtensionValid(upload))
            {
                var fileName = upload.FileName;
                var extension = Path.GetExtension(fileName);

                //sitenin içinde uploads dizinine yüklenecek.
                var uploadLocation = Path.Combine(hostingEnvironment.WebRootPath, "uploads");

                //eğer upload dizini yoksa oluştur.
                if (!Directory.Exists(uploadLocation))
                {
                    Directory.CreateDirectory(uploadLocation);
                }

                uploadLocation += "/" + fileName;

                //resmin yüklenme işlemi
                using (var stream = new FileStream(uploadLocation, FileMode.Create))
                {
                    await upload.CopyToAsync(stream);
                }
                return fileName;
            }
            return null;
        }
    }
}

