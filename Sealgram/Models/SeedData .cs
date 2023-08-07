using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sealgram.Data;
using Sealgram.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SealgramDbContext(
                   serviceProvider.GetRequiredService<DbContextOptions<SealgramDbContext>>()))
        {
            // Look for any users.
            if (context.Users.Any())
            {
                return; // DB has been seeded
            }

            context.Users.AddRange(
                new User
                {
                    username = "user1",
                    email = "user1@example.com",
                    password = "password1",
                    created_at = DateTime.UtcNow
                },
                new User
                {
                    username = "user2",
                    email = "user2@example.com",
                    password = "password2",
                    updated_at = DateTime.UtcNow
                }
                // Add more users as needed
            );

            context.SaveChanges();
        }
    }
}