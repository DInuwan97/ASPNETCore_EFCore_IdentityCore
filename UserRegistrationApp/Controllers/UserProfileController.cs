using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationApp.Models;

namespace UserRegistrationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {

      private readonly UserManager<ApplicationUser> _userManager;

        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

      [HttpGet]
      [Authorize]
      [Route("Profile")]
        //GET:/api/UserProfile
        public async Task<Object> GetUserProfile()
      {
            String userId = User.Claims.FirstOrDefault(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
               user.FullName,
               user.Email,
               user.UserName,
               user.PhoneNumber
            };
      }
    }
}
