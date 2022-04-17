using System.Collections.Generic;
using Example.Models;

namespace Example.Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
    }
    
    public class ProfileService : IProfileService
    {
        public IEnumerable<Profile> GetProfiles()
        {
            return new[]
            {
                new Profile { Name = "John", Age = 25, Gender = "Male", Interests = new[] {"Dinosaurs", "Penguins"} },
                new Profile { Name = "Mary", Age = 28, Gender = "Female", Interests = new[] {"Cooking"} },
                new Profile { Name = "Dustin", Age = 22, Gender = "Male", Interests = new[] {"Reading", "Walking"} }
            };
        } 
    }
}