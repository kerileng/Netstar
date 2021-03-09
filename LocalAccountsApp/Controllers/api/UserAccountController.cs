using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Profiler.Controllers.api
{
    public class UserAccountController : ApiController
    {
        public void Register(User user)
        {
            using(var context = new NETSTAREntities())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
