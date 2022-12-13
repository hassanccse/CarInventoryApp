using System;
using Microsoft.EntityFrameworkCore;
using CarInventoryApp.Shared.Models;

namespace CarInventoryApp.Server.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}
	public DbSet<Car>? Car { get; set; }
}

