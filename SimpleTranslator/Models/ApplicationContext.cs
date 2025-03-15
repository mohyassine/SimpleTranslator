using System;
using Microsoft.EntityFrameworkCore;

namespace SimpleTranslator.Models;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<ILanguage> Languages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<ILanguage>().HasData(
            new SourceLanguage(),
            new DestinationLanguage()
        );
    }

}
