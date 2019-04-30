using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AISFormations.Web.Models
{
    public class FormationsContext : DbContext
    {
        public FormationsContext(DbContextOptions<FormationsContext> options) : base (options) { }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<Participant> Participants { get; set; }
    }
}
