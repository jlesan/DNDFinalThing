using System.Data.Entity;
using FinalDNDSheetProj.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DNDCharSheet.Models;

namespace FinalDNDSheetProj.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<DNDCharSheet.Models.Characters> Characters { get; set; }
        public DbSet<CharacterArmor> CharacterArmor { get; set; }
        public DbSet<CharacterInventory> CharacterInventory { get; set; }
        public DbSet<CharacterSkills> CharacterSkills { get; set; }
        public DbSet<CharacterStats> CharacterStats { get; set; }
        public DbSet<CharacterWeapons> CharacterWeapons { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Spells> Spells { get; set; }
    }
}