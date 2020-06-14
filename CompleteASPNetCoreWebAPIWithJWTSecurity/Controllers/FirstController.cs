using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CompleteASPNetCoreWebAPIWithJWTSecurity.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        
        public string Get()
        {
            return "Welcome";
        }
         
    }
}
