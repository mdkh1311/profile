using System.Collections.Generic;
using System.Linq;
using Example.Data;
using Example.Models;

namespace Example.Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
    }
    
    public class ProfileService : IProfileService
    {
        private readonly ProfilesDbContext context;
        
        public ProfileService(ProfilesDbContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Profile> GetProfiles()
        {
            return context.Profile.Select(o => new Profile
                {
                    Name = o.Name,
                    Age = o.Age,
                    Interests = o.Interests,
                    Gender = o.Gender
                })
                .ToList();
        } 
    }
}