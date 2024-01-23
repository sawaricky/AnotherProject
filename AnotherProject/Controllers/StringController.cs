using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnotherProject.Controllers
{
    public class StringController : ApiController
    {
        //GOAL: configure a certain response for an input HTTP request

        //what the input is going to looklike
        //Get local: xx/api/string

        //the output os going to look like
        // "Hello: 


        public string Get(String nd)
        {
            //string message = "Hello" + "class";
            //string concatenation
            string message = "Hello" + nd + "!";
            return message;
        }
        //Goal:
        //method which serve":
        // Post: local: xx/api/string

        //post allows to submit a form 

        //in cmd
        //curl -d "" local: xx/api/string
        //output hello
        public string Post()
        {
            return "hello";
        }

    }
}
