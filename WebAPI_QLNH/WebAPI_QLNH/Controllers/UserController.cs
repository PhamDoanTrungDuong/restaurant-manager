using AutoMapper;
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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy tất cả danh sách Users
        /// </summary>
        /// <returns>Danh sách Users</returns>
        //[HttpGet]
        //public IEnumerable<User> Get()
        //{
        //    return _context.Users.ToList();
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            try
            {
                var data = await _context.Users.Select(d => new User 
                {
                        Id = d.Id,
                        UserName = d.UserName,
                        Description = d.Description,
                        Created = d.Created,
                        Updated = d.Updated,
                        Deleted = d.Deleted,
                        OffDuty = d.OffDuty,
                        Role = d.Role,
                        CreatedUser = _context.Users
                                            .Where(c => c.Id == d.CreatedUserId)
                                            .Select(s => new User {
                                                Id = s.Id,
                                                UserName = s.UserName,
                                                Description = s.Description,
                                                Created = s.Created,
                                                Updated = s.Updated,
                                                Deleted = s.Deleted,
                                                OffDuty = s.OffDuty,
                                                Role = s.Role,
                                            })
                                            .ToList(),
                    UpdatedUser = _context.Users
                                            .Where(c => c.Id == d.UpdatedUserId)
                                            .Select(s => new User
                                            {
                                                Id = s.Id,
                                                UserName = s.UserName,
                                                Description = s.Description,
                                                Created = s.Created,
                                                Updated = s.Updated,
                                                Deleted = s.Deleted,
                                                OffDuty = s.OffDuty,
                                                Role = s.Role,
                                            })
                                            .ToList()

                }).ToArrayAsync();
                var model = _mapper.Map<IEnumerable<UserDTO>>(data);
                return new JsonResult(model);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("not good");
            }
        }

        /// <summary>
        /// Lấy User với Id
        /// </summary>
        /// <returns>User</returns>
        /// <param name="Id">Tham số là Id của User</param>
        [HttpGet("Id")]
        public Object Get([FromQuery] int Id)
        {
            return _context.Users.Where(user => user.Id == Id).Select(s => new
            {
                Id = s.Id,
                UserName = s.UserName
            }).FirstOrDefault();
        }

        /// <summary>
        /// Thêm User mới
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPost]
        public User Post([FromQuery] User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
            return User;
        }

        /// <summary>
        /// Thêm User mới
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPut]
        public User Put([FromQuery] User User)
        {
            var user = _context.Users.Find(User.Id);
            if (user == null)
            {
                return null;
            }
            user.UserName = User.UserName;
            user.Password = User.Password;
            _context.SaveChanges();
            return user;
        }
    }
}