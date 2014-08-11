using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;


namespace SportsStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View(repository.Products);
        }
        public ViewResult Edit(int productId)
        {
            //метод находит товар с ID, который соответствует параметру productId, и передает его в качестве объекта модели представления.
            Product product = repository.Products
              .FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Product());
        }
        [HttpPost]
        public ActionResult Delete(int productId) {
  Product deletedProduct = repository.DeleteProduct(productId);
  if (deletedProduct != null) {
    TempData["message"] = string.Format("{0} was deleted", deletedProduct.Name);
  }
  return RedirectToAction("Index");
}
    }
}
