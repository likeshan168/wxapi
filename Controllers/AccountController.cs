using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace wxapi.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // [HttpGet]
        // public bool Get(User user)
        // {
        //     try
        //     {
        //         if (user.UserName == "amdin" && user.Password == "admin")
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        //     catch (System.Exception)
        //     {
        //         return false;
        //     }

        // }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost, EnableCors("CorsSample")]
        public bool Post(User user)
        {
            try
            {
                if (user.UserName == "admin" && user.Password == "admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
