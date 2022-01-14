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
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public RoleController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy tất cả danh sách Roles
        /// </summary>
        /// <returns>Danh sách Roles</returns>
        //[HttpGet]
        //public IEnumerable<Role> Get()
        //{
        //    return _context.Roles.ToList();
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleDTO>>> Get()
        {
            try
            {
                var data = await _context.Roles.Select(d => new Role
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    Created = d.Created,
                    Updated = d.Updated,
                    Deleted = d.Deleted,
                    Restaurant = d.Restaurant,
                }).ToArrayAsync();

                var model = _mapper.Map<IEnumerable<RoleDTO>>(data);
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
        public Role Get([FromQuery] int Id)
        {
            return _context.Roles.Where(role => role.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Post([FromBody] Role Role)
        {
            _context.Roles.Add(Role);
            _context.SaveChanges();
            return Role;
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPut]
        public Role Put([FromBody] Role role)
        {
            var ro = _context.Roles.Find(role.Id);

            if (ro == null)
            {
                return role;
            }
            ro.Name = role.Name;
            ro.Description = role.Description;

            _context.SaveChanges();
            return role;
        }
    }
}
