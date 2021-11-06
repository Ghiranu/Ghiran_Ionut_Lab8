using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghiran_Ionut_Lab8.Models;

namespace Ghiran_Ionut_Lab8.Data
{
    public class Ghiran_Ionut_Lab8Context : DbContext
    {
        public Ghiran_Ionut_Lab8Context (DbContextOptions<Ghiran_Ionut_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ghiran_Ionut_Lab8.Models.Book> Book { get; set; }
    }
}
