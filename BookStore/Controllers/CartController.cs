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
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly CartRepository _cartRepository = new();

        [HttpGet]
        [Route("list")]
        [ProducesResponseType(typeof(ListResponse<CartModel>), (int)HttpStatusCode.OK)]
        public IActionResult GetCartItems(string keyword)
        {
           
            ListResponse<Cart> res = _cartRepository.GetCartItems(keyword);
            ListResponse<CartModel> listResponse= new ListResponse<CartModel>()
            {
                Results = res.Results.Select(c => new CartModel(c)),
                TotalRecords = res.TotalRecords,
            };
            return StatusCode(HttpStatusCode.OK.GetHashCode(),listResponse);
        }

        [HttpPost]
        public IActionResult AddCart(CartModel model)
        {
            if (model == null)
                return BadRequest();

            Cart cart = new Cart()
            {
                Id = model.Id,
                Quantity = 1,
                Bookid = model.BookId,
                Userid = model.UserId
            };
            cart = _cartRepository.AddCart(cart);

            return Ok(new CartModel(cart));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateCart(CartModel model)
        {
            if (model == null)
                return BadRequest();

            Cart cart = new Cart()
            {
                Id = model.Id,
                Quantity = model.Quantity,
                Bookid = model.BookId,
                Userid = model.UserId
            };
            cart = _cartRepository.UpdateCart(cart);

            return Ok(new CartModel(cart));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteCart(int id)
        {
            if (id == 0)
                return BadRequest();

            bool response = _cartRepository.DeleteCart(id);
            return Ok(response);
        }
    }
}
