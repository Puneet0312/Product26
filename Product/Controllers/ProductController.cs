using Microsoft.AspNetCore.Mvc;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _Db;
        public ProductController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult ProductList()
        {
            try
            {
                // var prdList=_Db.tbl_Product.ToList(); -> single table data only and show all the data
                var prdList = from a in _Db.tbl_Products
                              join b in _Db.tbl_Category
                              on a.CatId equals b.Id
                              into Cat
                              from b in Cat.DefaultIfEmpty()

                              select new ProductM
                              {
                                  Id = a.Id,
                                  Title = a.Title,
                                  Quantity = a.Quantity,
                                  Price = a.Price,
                                  Image = a.Image,
                                  Description = a.Description,
                                  CatId=a.CatId,
                                  Category = a == null ? "" : a.Category

                              };
                return View(prdList);

            }
            catch (Exception )
            {
                return View();
            }
            
        }
    
         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>AddProduct(ProductM obj)
        {
            try
            {
                return View();
            }
            catch(Exception)
            {
                return RedirectToAction(" ProductList");

            }
        }
    }
}
