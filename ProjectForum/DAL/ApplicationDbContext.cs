using DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<ApplicationUser> Users {get;set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            

            modelBuilder.Entity<Comment>()
                .HasRequired(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PostId);
             

            modelBuilder.Entity<Comment>()
              .HasRequired(x => x.User)
              .WithMany(x => x.Comments)
              .HasForeignKey(x => x.UserId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Category>()
                .HasMany(x => x.Posts)
                .WithMany(x => x.Categories);           

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
