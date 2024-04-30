using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace backendnet.Data.Seed;

public static class SeedIdentityUserData
{
    public static void SeedUserIdentityData(this ModelBuilder modelBuilder)
    {
        string AdministradorRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = AdministradorRoleId,
            Name = "Administrador",
            NormalizedName = "Administrador".ToUpper()
        });

        string UsuarioRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = UsuarioRoleId,
            Name = "Usuario",
            NormalizedName = "Usuario".ToUpper()
        });

        var UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName = "antonio@uv.mx",
                Email = "antonio@uv.mx",
                NormalizedEmail = "antonio@uv.mx".ToUpper(),
                Nombre = "José Antonio Espinoza Rodríguez",
                NormalizedUserName = "antonio@.uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "galleta"),
                Protegido = true
            }
            
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorRoleId,
                UserId = UsuarioId
            }
        );

        UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName = "charles@uv.mx",
                Email = "charles@uv.mx",
                NormalizedEmail = "charles@uv.mx".ToUpper(),
                Nombre = "Usuario Charles",
                NormalizedUserName = "charles@.uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "charles"),
                Protegido = true

            }
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorRoleId,
                UserId = UsuarioId
            }
        );
    }
}