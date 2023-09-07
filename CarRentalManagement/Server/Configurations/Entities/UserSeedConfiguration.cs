﻿using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
	internal class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();
			_ = builder.HasData(
				new ApplicationUser
				{
					Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
					Email = "admin@localhost.com",
					NormalizedEmail = "ADMIN@LOCALHOST.COM",
					FirstName = "System",
					LastName = "Admin",
					UserName = "admin@localhost.com",
					NormalizedUserName = "ADMIN@LOCALHOST.COM",
					PasswordHash = hasher.HashPassword(user: null, password: "P@ssword1")
				},
				new ApplicationUser
				{
					Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
					Email = "user@localhost.com",
					NormalizedEmail = "USER@LOCALHOST.COM",
					FirstName = "System",
					LastName = "User",
					UserName = "user@localhost.com",
					NormalizedUserName = "USER@LOCALHOST.COM",
					PasswordHash = hasher.HashPassword(user: null, "P@ssword1")
				}
				);
		}
	}
}