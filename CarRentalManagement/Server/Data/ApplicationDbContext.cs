using CarRentalManagement.Server.Configurations.Entities;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
		public ApplicationDbContext(
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
			DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<Colour> Colours { get; set; }
		public DbSet<Make> Makes { get; set; }
		public DbSet<Model> Models { get; set; }
		public DbSet<Customer> Customers { get; set; }

		public DbSet<Booking> Bookings { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new ColourSeedConfiguration());
			builder.ApplyConfiguration(new MakeSeedConfiguration());
			builder.ApplyConfiguration(new ModelSeedConfiguration());
			builder.ApplyConfiguration(new RoleSeedConfiguration());
			builder.ApplyConfiguration(new UserSeedConfiguration());
			builder.ApplyConfiguration(new UserRoleSeedConfiguration());
		}
	}
}