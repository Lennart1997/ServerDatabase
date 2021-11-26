using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestServer.Data
{
    
    public class AdultRepo : IAdultRepo
    {
        
        protected DBContext ctx;


        public AdultRepo(DBContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Adult>> ReadAllAdults()
        {
            List<Adult> adults = ctx.Adults.ToList();
            return adults;
            
        }

        public async Task<Adult> AddAdult(Adult addAdult)
        {
            await ctx.Adults.AddAsync(addAdult);
            await ctx.SaveChangesAsync();

            return addAdult;
        }
        
        public async Task DeleteAdult(int deleteAdult)
        {
            Adult firstAsync = await ctx.Adults.Include(j=>j.JobTitle).FirstAsync(adult => adult.Id == deleteAdult);
            ctx.Remove(firstAsync);
            await ctx.SaveChangesAsync();
            
        }
        
        public async Task<Adult> UpdateAdult(Adult updateAdult)
        {
            ctx.Update(updateAdult);
            await ctx.SaveChangesAsync();
            return updateAdult;

        }
        
    }
}