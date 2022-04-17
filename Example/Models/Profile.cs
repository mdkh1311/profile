using System.Collections.Generic;

namespace Example.Models
{
    public class Profile
    {
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public IEnumerable<string> Interests { get; set; }
        
        public string Gender { get; set; }
    }
}