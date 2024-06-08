using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventSphere.Models;


namespace EventSphere.Data
{
    public class EventSphereContext : DbContext
    {
        public EventSphereContext (DbContextOptions<EventSphereContext> options)
            : base(options)
        {
        }
        public DbSet<EventSphere.Models.User> User { get; set; } = default!;

        
    }
}
