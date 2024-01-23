using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnotherProject.Controllers
{
    public class ExampleController : ApiController
    {
       public ExampleController() { }
       //Get: localhost:xx/api/example
            public int Get()
        {
            return -1;
        }

        //Get: localhost:xx/api/example/3
        //new comment
         // <summary>
         // <summart 
        public int Get(int id)
        {
            int result = id / 2;
            return result;
        }
    }
}
