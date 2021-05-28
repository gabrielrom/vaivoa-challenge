using System;
using Microsoft.EntityFrameworkCore;

namespace Card {
  public class CardContext : DbContext {
    public DbSet<Card> Cards { get; set; }

    public CardContext(DbContextOptions<CardContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.Entity<Card>().HasKey(c => c.id);
    }
  }
}