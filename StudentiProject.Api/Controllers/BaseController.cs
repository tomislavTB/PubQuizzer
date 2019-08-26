﻿using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace StudentiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult ApiOk()
        {
            return ApiOk(HttpStatusCode.OK, null);
        }

        protected IActionResult ApiOk(object data)
        {
            return ApiOk(HttpStatusCode.OK, data);
        }

        protected IActionResult ApiOk(HttpStatusCode code, object data)
        {
            return Ok(StudentiProject.ApiResponse.ApiResponse.Ok(code, data));
        }
    }
}

