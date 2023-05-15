using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicket.Controllers
{
    public class SeatDetailController : ApiController
    {
        [HttpGet]
        [Route("api/seatdetails")]
        public HttpResponseMessage SeatDetails()
        {
            try
            {
                var data = SeatDetailService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/seatdetail/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, SeatDetailService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/seatdetail/create")]
        [HttpPost]
        public HttpResponseMessage Create(SeatDetailDTO seatdetail)
        {
            try
            {
                var data = SeatDetailService.Create(seatdetail);
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
        [Route("api/seatdetail/update/{id}")]
        public HttpResponseMessage UpdateSeatDetail(SeatDetailDTO seatdetail)
        {

            try
            {
                var data = SeatDetailService.Update(seatdetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
