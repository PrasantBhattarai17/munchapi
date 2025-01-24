using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using MunchyAPI.Models;

namespace MunchyAPI.Data
{
    public class ApplicationDBContext:DbContext
    {
        //for configuring the entitiyFW core the connection string must be passed into the DbContext so using constructor
        //connsctionstring is passed into the DbContext
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option):base(option)
        {
            
            
        }
        public DbSet<munch> Munches_API { get; set; }
       
    }
}
