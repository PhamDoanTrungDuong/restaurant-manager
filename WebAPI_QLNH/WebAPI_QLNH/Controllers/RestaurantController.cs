using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_QLNH.Data;
using WebAPI_QLNH.DTO;
using WebAPI_QLNH.Models;

namespace WebAPI_QLNH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public RestaurantController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy tất cả danh sách Roles
        /// </summary>
        /// <returns>Danh sách Roles</returns>
        //[HttpGet]
        //public IEnumerable<Restaurant> Get()
        //{
        //    return _context.Restaurants
        //                    .Where(c => !c.Deleted)
        //                    .Include(r => r.CreatedUser)
        //                    .Include(r => r.UpdatedUser)
        //                    .ToList();
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantDTO>>> Get()
        {
            try
            {
                Task.Delay(500).Wait();
                var data = await _context.Restaurants
                          .Include(r => r.CreatedUser)
                          .Include(r => r.UpdatedUser)
                          .ToArrayAsync();
                var model = _mapper.Map<IEnumerable<RestaurantDTO>>(data);
                return new JsonResult(model);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("not good");
            }
        }

        /// <summary>
        /// Lấy Role với Id
        /// </summary>
        /// <returns>Danh sách Role</returns>
        /// <param name="Id">Tham số là Id của Role</param>
        [HttpGet("Id")]
        public Restaurant Get([FromQuery] int Id)
        {
            return _context.Restaurants.Where(res => res.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Restaurant Post([FromBody] Restaurant restaurant)
        {
            var createdUser = _context.Users.Find(restaurant.CreatedUser.Id);
            restaurant.CreatedUser = createdUser;
            var updateUser = _context.Users.Find(restaurant.UpdatedUser.Id);
            restaurant.UpdatedUser = updateUser;

            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPut]
        public Restaurant Put([FromBody] Restaurant restaurant)
        {
            var res = _context.Restaurants.Find(restaurant.Id);

            if(res == null)
            {
                return restaurant;
            }
            res.Name = restaurant.Name;
            res.Description = restaurant.Description;
            res.Phone = restaurant.Phone;
            res.Address = restaurant.Address;

            var updateUser = _context.Users.Find((restaurant.UpdatedUser != null) ? restaurant.UpdatedUser.Id : 1);
            restaurant.UpdatedUser = updateUser;

            _context.SaveChanges();
            return restaurant;
        }
    }
}
