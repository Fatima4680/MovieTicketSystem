using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketSystem.Controllers
{
    public class DiscountController : ApiController
    {
        [HttpGet]
        [Route("api/discounts")]
        public HttpResponseMessage Discounts()
        {
            try
            {
                var data = DiscountService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/discount/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, DiscountService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/discount/create")]
        [HttpPost]
        public HttpResponseMessage Create(DiscountDTO discount)
        {
            try
            {
                var data = DiscountService.Create(discount);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/discount/update/{id}")]
        
        public HttpResponseMessage UpdateDiscount(DiscountDTO discount)
        {

            try
            {
                var data = DiscountService.Update(discount);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
