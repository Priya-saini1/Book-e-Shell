using BookStore.Models.Models;
using BookStore.Models.ViewModels;
using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("role")]
    public class RoleController : ControllerBase
    {
        RoleRespository _repository = new RoleRespository();
       [HttpGet]
        [Route("list")]
        [ProducesResponseType(typeof(List<RoleModel>),(int)HttpStatusCode.OK)]
        public IActionResult GetAllRoles()
        {
            var roles = _repository.getAllRoles();
            ListResponse<RoleModel> listResponse = new ListResponse<RoleModel>()
            {
                Results = roles.Results.Select(c => new RoleModel(c)),
                 TotalRecords = roles.TotalRecords,
            };
                return StatusCode(HttpStatusCode.OK.GetHashCode(),listResponse);
        }
    }
}
