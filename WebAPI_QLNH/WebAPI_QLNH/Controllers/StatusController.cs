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
    public class StatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public StatusController(ApplicationDbContext context, IMapper mapper)
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
        public async Task<ActionResult<IEnumerable<StatusDTO>>> Get()
        {
            try
            {
                var data = await _context.Status
                          .Include(r => r.CreatedUser)
                          .Include(r => r.UpdatedUser)
                          .ToArrayAsync();
                var model = _mapper.Map<IEnumerable<StatusDTO>>(data);
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
        public Status Get([FromQuery] int Id)
        {
            return _context.Status.Where(res => res.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Status Post([FromBody] Status status)
        {
            var createdUser = _context.Users.Find(status.CreatedUser.Id);
            status.CreatedUser = createdUser;
            var updateUser = _context.Users.Find(status.UpdatedUser.Id);
            status.UpdatedUser = updateUser;

            _context.Status.Add(status);
            _context.SaveChanges();
            return status;
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPut]
        public Status Put([FromBody] Status status)
        {
            var res = _context.Status.Find(status.Id);

            if (res == null)
            {
                return status;
            }
            res.Name = status.Name;
            res.Description = status.Description;

            var updateUser = _context.Users.Find((status.UpdatedUser != null) ? status.UpdatedUser.Id : 1);
            status.UpdatedUser = updateUser;

            _context.SaveChanges();
            return status;
        }
    }
}
