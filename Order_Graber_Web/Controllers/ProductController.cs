using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CUSTOMERS = Order_Graber_DataService.PRODUCTS;
using Order_Graber_Web.Models;

namespace Order_Graber_Web.Controllers
{
    public class ProductController : Controller
    {
        private Order_Graber_DataService.Services.ProductService productService;

        public ActionResult IndexProduct()
        {
            ViewBag.Title = "Productos";

            productService = new Order_Graber_DataService.Services.ProductService();

            return View(productService.GetAllProducts());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PRODUCTS datosFront)
        {
            try
            {
                productService = new Order_Graber_DataService.Services.ProductService();
                Order_Graber_DataService.PRODUCTS newProduct = new Order_Graber_DataService.PRODUCTS()
                {
                    product_code = datosFront.product_code,
                    product_name = datosFront.product_name,
                    cost_price = datosFront.cost_price,
                    sale_price = datosFront.sale_price,
                    state = datosFront.state
                };

                productService.InsertProduct(newProduct);
                return RedirectToAction("IndexProduct");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            productService = new Order_Graber_DataService.Services.ProductService();
            Order_Graber_DataService.PRODUCTS deleteProduct = new Order_Graber_DataService.PRODUCTS();

            deleteProduct = productService.GetProductById(id);



            return View(deleteProduct);
        }

        [HttpPost]
        public ActionResult Delete(int id, PRODUCTS datosFront)
        {
            try
            {
                productService = new Order_Graber_DataService.Services.ProductService();
                Order_Graber_DataService.PRODUCTS deleteProduct = new Order_Graber_DataService.PRODUCTS()
                {
                    product_id = id,
                };

                productService.DeleteProduct(deleteProduct.product_id);

                return RedirectToAction("IndexProduct");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            productService = new Order_Graber_DataService.Services.ProductService();
            Order_Graber_DataService.PRODUCTS editProduct = new Order_Graber_DataService.PRODUCTS();


            editProduct = productService.GetProductById(id);


            return View(editProduct);
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order_Graber_DataService.PRODUCTS datosFront)
        {
            try
            {
                productService = new Order_Graber_DataService.Services.ProductService();
                Order_Graber_DataService.PRODUCTS updateProduct = new Order_Graber_DataService.PRODUCTS()
                {
                    product_id = id,
                    product_code = datosFront.product_code,
                    product_name = datosFront.product_name,
                    cost_price = datosFront.cost_price,
                    sale_price = datosFront.sale_price,
                    state = datosFront.state,

                };

                productService.UpdateProduct(updateProduct);
                return RedirectToAction("IndexProduct");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail(int id)
        {
            productService = new Order_Graber_DataService.Services.ProductService();
            Order_Graber_DataService.PRODUCTS detailProduct = new Order_Graber_DataService.PRODUCTS();


            detailProduct = productService.GetProductById(id);


            return View(detailProduct);
        }


    }
}