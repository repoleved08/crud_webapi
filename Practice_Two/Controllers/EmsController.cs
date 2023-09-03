using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Practice_Two.Entities;
using Practice_Two.Requests;
using Practice_Two.ResponseDTO;

namespace Practice_Two.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmsController : ControllerBase
    {
        // Making this staic so as to only have one instance
        private static List<EmsUsers> _users = new()
        {
            {
                new EmsUsers()
                {
                    Id = Guid.NewGuid(),
                    Name="Kipngetich",
                    PhoneNumber = 0718276384,
                    Email = "geekbii08@gmail.com"
                }
            }
        };
        private readonly IMapper _mapper;
        public EmsController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // Getting All users
        [HttpGet]
        public ActionResult<List<EmsUsers>> GetAllUsers()
        {
            // Transformation
            var users = _mapper.Map<List<EmsResponse>>(_users);
            return Ok(users);
        }
        [HttpGet("id")]
        //[Route("{id}")]
        // Getting one instance of a user
         public ActionResult<EmsUsers> GetUser(Guid id)
        {
            try
            {
                var existingUser = _users.First(x=>x.Id == id);
                // Transformation
                var user = _mapper.Map<EmsResponse>(existingUser);
                return Ok(user);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<EmsSuccess> PostEmsUser(AddEmsUser user)
        {
            // We should post data as EmsUser, but we are getting AddUser
            var newUser = _mapper.Map<EmsUsers>(user);
            newUser.Id = Guid.NewGuid();
            _users.Add(newUser);
            return Ok(new EmsSuccess(201, "User Added Successfully"));
        }
        [HttpPut("id")]
        public ActionResult<EmsSuccess> PutEmsUser (Guid id, AddEmsUser updateUserDetails)
        {
            var existingDetails = _users.FirstOrDefault(x=>x.Id == id);
            if (existingDetails != null)
            {
                // existingDetails.Name = updateUserDetails.Name;
                // existingDetails.PhoneNumber = updateUserDetails.PhoneNumber;
                // existingDetails.Email = updateUserDetails.Email;
                // existingDetails.Password = updateUserDetails.Password;
                _mapper.Map(updateUserDetails, existingDetails);
                return Ok(new EmsSuccess(204, "User details Updated Successfully"));
            }
            return NotFound("User Not Found!");
        }
        // Delete User Details
        [HttpDelete("id")]
        public ActionResult<EmsSuccess> DeleteEmsUser (Guid id, AddEmsUser updateUserDetails)
        {
            var existingDetails = _users.FirstOrDefault(x=>x.Id == id);
            if (existingDetails != null)
            {
                _users.Remove(existingDetails);
                return Ok(new EmsSuccess(204, "User details Removed Successfully"));
            }
            return NotFound("User Not Found!");
        }
    }
}
