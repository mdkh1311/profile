using Example.Data.Interfaces;

namespace Example.Data.Entities
{
    public class Profile : IHasId
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public string[] Interests { get; set; }
        
        public string Gender { get; set; }
    }
}