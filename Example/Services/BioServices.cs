using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Data;
using Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Services
{
    public interface IBioService
    {
        Task<IEnumerable<Bio>> GetBiosAsync();
    }
    
    public class BioService : IBioService
    {
        private readonly ProfilesDbContext context;
        
        public BioService(ProfilesDbContext context)
        {
            this.context = context;
        }
        
        public async Task<IEnumerable<Bio>> GetBiosAsync()
        {
            return await context.Bio.Select(o => new Bio
                {
                    BioText = o.BioText,
                })
                .ToListAsync();
        } 
    }
}