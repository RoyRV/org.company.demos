﻿
using org.company.order.application.contracts;
using org.company.order.entities;
using org.company.order.service.model;
using System.Collections.Generic;
using System.Web.Http;

namespace org.company.order.service.Controllers
{
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
         
        }

        [HttpGet]
        [Route("orders/{id}")]
        public IHttpActionResult GetOrdersByCustomer(int id)
        {
            var result = _service.GetOrdersByCustomerId(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("order/{id}")]
        public IHttpActionResult GetOrderById(int id)
        {
            var result = _service.GetOrderById(id);

            return Ok(result);
        }

        [HttpGet]
        [Route("products")]
        public IHttpActionResult GetProducts()
        {
            var result = _service.GetProducts();
            return Ok(result);
        }

        [HttpPost]
        [Route("save")]
        public void Post([FromBody]OrderDTO order)
        {
            _service.AddOrder(order);
        }

    }
}
