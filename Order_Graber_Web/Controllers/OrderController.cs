using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order_Graber_Web.Models;
using ORDERS = Order_Graber_DataService.ORDERS;

namespace Order_Graber_Web.Controllers
{
    public class OrderController : Controller
    {
        private Order_Graber_DataService.Services.OrderService orderService;
        // GET: Order
        public ActionResult IndexOrder()
        {
            ViewBag.Title = "Ordenes";

            orderService = new Order_Graber_DataService.Services.OrderService();

            var customersList = orderService.GetAllOrders();


            return View(customersList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ORDERS datosFront)
        {
            try
            {
                orderService = new Order_Graber_DataService.Services.OrderService();
                ORDERS newOrder = new ORDERS()
                {
                    client_id = datosFront.client_id,
                    order_date = datosFront.order_date,
                    total_order = datosFront.total_order,
                    state = datosFront.state,
                };

                orderService.InsertOrder(newOrder);
                return RedirectToAction("IndexOrder");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            orderService = new Order_Graber_DataService.Services.OrderService();
            ORDERS deleteOrder = new ORDERS();

            deleteOrder = orderService.GetOrderById(id);



            return View(deleteOrder);
        }

        [HttpPost]
        public ActionResult Delete(int id, ORDERS datosFront)
        {
            try
            {
                orderService = new Order_Graber_DataService.Services.OrderService();
                ORDERS deleteOrder = new ORDERS()
                {
                    order_id = id,
                };

                orderService.DeleteOrder(deleteOrder.order_id);

                return RedirectToAction("IndexOrder");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            orderService = new Order_Graber_DataService.Services.OrderService();
            ORDERS editOrder = new ORDERS();

            editOrder = orderService.GetOrderById(id);

            return View(editOrder);
        }

        [HttpPost]
        public ActionResult Edit(int id, Order_Graber_DataService.ORDERS datosFront)
        {
            try
            {
                orderService = new Order_Graber_DataService.Services.OrderService();
                Order_Graber_DataService.ORDERS updateOrder = new Order_Graber_DataService.ORDERS()
                {
                    order_id = id,
                    client_id = datosFront.client_id,
                    order_date = datosFront.order_date,
                    total_order = datosFront.total_order,
                    state = datosFront.state,
                };
                orderService.UpdateOrder(updateOrder);
                return RedirectToAction("IndexOrder");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail(int id)
        {
            orderService = new Order_Graber_DataService.Services.OrderService();
            ORDERS detailOrder = new ORDERS();

            detailOrder = orderService.GetOrderById(id);

            return View(detailOrder);
        }

    }
}