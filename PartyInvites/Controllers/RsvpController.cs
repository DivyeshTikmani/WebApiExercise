using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PartyInvites.Controllers
{
    public class RsvpController : ApiController
    {
        public IEnumerable<GuestResponse> GetAttendees()
        {
            return Repository.Responses.Where(a => a.WillAttend == true);
        }

        public void Response(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
            }
        }
    }
}
