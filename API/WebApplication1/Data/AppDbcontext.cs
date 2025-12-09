using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Entities;

namespace WebApplication1.Data;

public class AppDbcontext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
