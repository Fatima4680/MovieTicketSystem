using BLL.DTOs;
using BLL.Services;
using MovieTicketSystem.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovieTicketManagement.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ManagerController : ApiController
    {


        [HttpGet]
        [Route("api/managers")]
        public HttpResponseMessage Managers()
        {
            try
            {
                var data = ManagerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Logged]
        [Route("api/manager/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ManagerService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/manager/create")]
        [HttpPost]
        public HttpResponseMessage Create(ManagerDTO manager)
        {
            try
            {
                var data = ManagerService.Create(manager);
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
        [Route("api/manager/update/{id}")]
        public HttpResponseMessage UpdateUser(ManagerDTO manager)
        {

            try
            {
                var data = ManagerService.Update(manager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



        [Route("api/manager/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteUser(string id)
        {
            var data = ManagerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }



    }
}
