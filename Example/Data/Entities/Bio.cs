using Example.Data.Interfaces;

namespace Example.Data.Entities
{
    public class Bio : IHasId
    {
        public int Id { get; set; }
        
        public string BioText { get; set; }
    }
}