using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Profile>> GetProfiles()
        {
            return await profileService.GetProfilesAsync();
        }
    }
}