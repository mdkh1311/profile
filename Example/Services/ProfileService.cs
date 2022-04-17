using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Data;
using Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Services
{
    public interface IProfileService
    {
        Task<IEnumerable<Profile>> GetProfilesAsync();
    }
    
    public class ProfileService : IProfileService
    {
        private readonly ProfilesDbContext context;
        
        public ProfileService(ProfilesDbContext context)
        {
            this.context = context;
        }
        
        public async Task<IEnumerable<Profile>> GetProfilesAsync()
        {
            return await context.Profile.Select(o => new Profile
                {
                    Name = o.Name,
                    Age = o.Age,
                    Interests = o.Interests,
                    Gender = o.Gender
                })
                .ToListAsync();
        } 
    }
}