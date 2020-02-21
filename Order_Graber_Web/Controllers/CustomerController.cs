using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order_Graber_DataService;
using Order_Graber_Web.Models;
using CUSTOMERS = Order_Graber_DataService.CUSTOMERS;

namespace Order_Graber_Web.Controllers
{
    public class CustomerController : Controller
    {
        private Order_Graber_DataService.Services.CustomerService customerService;

        public ActionResult IndexCustomer()
        {
            ViewBag.Title = "Clientes";

            customerService = new Order_Graber_DataService.Services.CustomerService();

            var customersList = customerService.GetAllCustomers();
            

            return View(customersList);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CUSTOMERS datosFront)
        {
            try
            {
                customerService = new Order_Graber_DataService.Services.CustomerService();
                CUSTOMERS newCustomer = new CUSTOMERS()
                {
                    document_type = datosFront.document_type,
                    document_nro = datosFront.document_nro,
                    customer_name = datosFront.customer_name,
                    address = datosFront.address,
                    phone = datosFront.phone,
                    email = datosFront.email,
                    state = datosFront.state
                };

                customerService.InsertCustomer(newCustomer);
                return RedirectToAction("IndexCustomer");

            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Delete(int id)
        {
            customerService = new Order_Graber_DataService.Services.CustomerService();
            CUSTOMERS deleteCustomer = new CUSTOMERS();

            deleteCustomer = customerService.GetCustomerById(id);



            return View(deleteCustomer);
        }
        
        [HttpPost]
        public ActionResult Delete(int id, CUSTOMERS datosFront)
        {
            try
            {
                customerService = new Order_Graber_DataService.Services.CustomerService();
                CUSTOMERS deleteCustomer = new CUSTOMERS()
                {
                    client_id = id,
                };

                customerService.DeleteCustomer(deleteCustomer.client_id);

                return RedirectToAction("IndexCustomer");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            customerService = new Order_Graber_DataService.Services.CustomerService();
            CUSTOMERS editCustomer = new CUSTOMERS();


            editCustomer = customerService.GetCustomerById(id);


            return View(editCustomer);
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order_Graber_DataService.CUSTOMERS datosFront)
        {
            try
            {
                customerService = new Order_Graber_DataService.Services.CustomerService();
                Order_Graber_DataService.CUSTOMERS updateCustomer = new Order_Graber_DataService.CUSTOMERS()
                {
                    client_id = id,
                    document_type = datosFront.document_type,
                    document_nro = datosFront.document_nro,
                    customer_name = datosFront.customer_name,
                    address = datosFront.address,
                    phone = datosFront.phone,
                    email = datosFront.email,
                    state = datosFront.state,
                   
                };

                customerService.UpdateCustomer(updateCustomer);
                return RedirectToAction("IndexCustomer");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail(int id)
        {
            customerService = new Order_Graber_DataService.Services.CustomerService();
            CUSTOMERS detailCustomer = new CUSTOMERS();


            detailCustomer = customerService.GetCustomerById(id);


            return View(detailCustomer);
        }



    }
}