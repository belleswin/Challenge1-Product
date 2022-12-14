using System.Collections.Generic;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;


namespace newapi
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderHandler _OrderHandler = new OrderHandler();

        [HttpGet]
        [EnableCors("MyPolicy")]
        [Route("/order")]
        public IEnumerable < Order > order()
        {
            return _OrderHandler.GetOrder();
        }

        [HttpDelete]
        [EnableCors("MyPolicy")]
        [Route("/order")]
        public float Delete([FromBody]Order order)
        {
            return _OrderHandler.Delete(order);
        }

        [HttpPut]
        [EnableCors("MyPolicy")]
        [Route("/order")]
        public float AddOrder([FromBody]Order order)
        {
            return _OrderHandler.AddOrder(order);
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        [Route("/order/total")]
        public float Total([FromBody]Order order)
        {
        return _OrderHandler.Total(order);
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        [Route("/order/gst")]
        public float GST([FromBody]Order order)
        {
        return _OrderHandler.GST(order);
        }


        
        
    }
}