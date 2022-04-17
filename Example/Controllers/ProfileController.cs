using System.Collections.Generic;
using Example.Models;
using Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;

        public ProfileController(IProfileService profileService)
        {
            this.profileService = profileService;
        }

        [HttpGet]
        public IEnumerable<Profile> GetProfiles()
        {
            return profileService.GetProfiles();
        }
    }
}