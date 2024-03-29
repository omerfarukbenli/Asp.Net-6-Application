﻿using Application.Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //end point olarak alınmasın
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response) //createactionresultu kullandık
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode,
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
