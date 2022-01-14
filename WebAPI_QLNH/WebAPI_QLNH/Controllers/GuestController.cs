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
    public class GuestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GuestController(ApplicationDbContext context, IMapper mapper)
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
        public async Task<ActionResult<IEnumerable<GuestDTO>>> Get()
        {
            try
            {
                var data = await _context.Guests
                          .Include(r => r.CreatedUser)
                          .Include(r => r.UpdatedUser)
                          .ToArrayAsync();
                var model = _mapper.Map<IEnumerable<GuestDTO>>(data);
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
        public Guest Get([FromQuery] int Id)
        {
            return _context.Guests.Where(res => res.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Guest Post([FromBody] Guest guest)
        {
            var createdUser = _context.Users.Find(guest.CreatedUser.Id);
            guest.CreatedUser = createdUser;
            var updateUser = _context.Users.Find(guest.UpdatedUser.Id);
            guest.UpdatedUser = updateUser;

            _context.Guests.Add(guest);
            _context.SaveChanges();
            return guest;
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPut]
        public Guest Put([FromBody] Guest guest)
        {
            var res = _context.Guests.Find(guest.Id);

            if (res == null)
            {
                return guest;
            }
            res.Name = guest.Name;
            res.Description = guest.Description;
            res.Phone = guest.Phone;

            var updateUser = _context.Users.Find((guest.UpdatedUser != null) ? guest.UpdatedUser.Id : 1);
            guest.UpdatedUser = updateUser;

            _context.SaveChanges();
            return guest;
        }
    }
}
