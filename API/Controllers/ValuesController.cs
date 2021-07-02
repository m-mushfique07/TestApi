using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
       
        public HttpResponseMessage GetMessages()
        {
            List<demo_tushar> msgList = new List<demo_tushar>();
            using (TusharDbEntities db = new TusharDbEntities())
            {
                msgList = db.demo_tushars.ToList();
            }
            HttpResponseMessage response;
            response = Request.CreateResponse(HttpStatusCode.OK, msgList);

            return response;


        }

    }
}
