using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order_Graber_Web.Models;
using ORDERS_DETAIL = Order_Graber_DataService.ORDERS_DETAIL;

namespace Order_Graber_Web.Controllers
{
    public class OrderDetailController : Controller
    {
        private Order_Graber_DataService.Services.OrderDetailService orderDetailService;
        // GET: OrderDetail
        public ActionResult IndexOrdersDetail()
        {
            ViewBag.Title = "Detalle de ordenes";

            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();

            var ordersDetailList = orderDetailService.GetAllOrdersDetails();

            return View(ordersDetailList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ORDERS_DETAIL datosFront)
        {
            try
            {
                orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
                ORDERS_DETAIL newOrderDetail = new ORDERS_DETAIL()
                {
                    order_id = datosFront.order_id,
                    product_id = datosFront.product_id,
                    quantity = datosFront.quantity,
                    total_line = datosFront.total_line,
                    ORDERS = datosFront.ORDERS,
                    PRODUCTS = datosFront.PRODUCTS,
                };
                orderDetailService.InsertOrderDetail(newOrderDetail);
                return RedirectToAction("IndexOrdersDetail");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
            ORDERS_DETAIL deleteOrderDetail = new ORDERS_DETAIL();

            deleteOrderDetail = orderDetailService.GetOrderDetailsById(id);

            return View(deleteOrderDetail);
        }

        [HttpPost]
        public ActionResult Delete(int id, ORDERS_DETAIL datosFront)
        {
            try
            {
                orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
                ORDERS_DETAIL deleteOrderDetail = new ORDERS_DETAIL()
                {
                    order_id = id
                };
                orderDetailService.DeleteOrderDetail(deleteOrderDetail.line_id);

                return RedirectToAction("indexOrdersDetail");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
            ORDERS_DETAIL editOrderDetail = new ORDERS_DETAIL();

            editOrderDetail = orderDetailService.GetOrderDetailsById(id);

            return View(editOrderDetail);
        }

        [HttpPost]
        public ActionResult Edit(int id, Order_Graber_DataService.ORDERS_DETAIL datosFront)
        {
            try
            {
                orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
                Order_Graber_DataService.ORDERS_DETAIL updateOrderDetail = new Order_Graber_DataService.ORDERS_DETAIL()
                {
                    line_id = id,
                    order_id = datosFront.order_id,
                    product_id = datosFront.product_id,
                    quantity = datosFront.quantity,
                    total_line = datosFront.total_line,
                    ORDERS = datosFront.ORDERS,
                    PRODUCTS = datosFront.PRODUCTS,
                };
                orderDetailService.UpdateOrderDetail(updateOrderDetail);
                return RedirectToAction("IndexOrdersDetail");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Detail(int id)
        {
            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
            Order_Graber_DataService.ORDERS_DETAIL detailOrderDetail = new Order_Graber_DataService.ORDERS_DETAIL();

            detailOrderDetail = orderDetailService.GetOrderDetailsById(id);

            return View(detailOrderDetail);
        }

        
    }
}