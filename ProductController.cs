using Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
		
		// GET: Product
		public ActionResult Index()
        {
			ProjectEntities db = new ProjectEntities();
			List<Product> Viewlist = db.Products.ToList();
			List<ProductViewModel> List = new List<ProductViewModel>();
			foreach (Product a in Viewlist)
			{
				ProductViewModel ab = new ProductViewModel();
				ab.Product_Id = a.Product_Id;
				ab.Product_Name = a.Product_Name;
				ab.Description = a.Description;
				ab.Minimum_Bid_Amount = a.Minimum_Bid_Amount;
				ab.Auction_Time = a.Auction_Time;
				ab.Select_Category = a.Select_Category;
				ab.Added_by = a.Added_By;
				ab.Added_on = a.Added_On;
				List.Add(ab);
			}
			return View(List);
		}

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
		[Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
