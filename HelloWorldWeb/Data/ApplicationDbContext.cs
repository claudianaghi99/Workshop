﻿namespace HelloWorldWeb.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldWeb.Models.Skill> Skill { get; set; }

        public DbSet<HelloWorldWeb.Models.TeamMember> TeamMembers { get; set; }
    }
}
