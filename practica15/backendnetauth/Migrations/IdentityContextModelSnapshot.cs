﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendnet.Data;

#nullable disable

namespace backendnet.Migrations
{
    [DbContext(typeof(IdentityContext))]
    partial class IdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasPeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "PeliculasPeliculaId");

                    b.HasIndex("PeliculasPeliculaId");

                    b.ToTable("CategoriaPelicula");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "618ae9cf-3eaf-412e-a350-8bf56a66232e",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "7d88b070-f6aa-46a8-a867-04945b3d131e",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "2288571e-d274-4682-85ea-70655d1a6e9b",
                            RoleId = "618ae9cf-3eaf-412e-a350-8bf56a66232e"
                        },
                        new
                        {
                            UserId = "b11a2cff-aece-4063-bae7-3ce1674f0c9a",
                            RoleId = "618ae9cf-3eaf-412e-a350-8bf56a66232e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("backendnet.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Protegida")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Acción",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Aventura",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Animación",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Ciencia Ficción",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Comedia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Crimen",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Documental",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Drama",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Familiar",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Fantasma",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Historia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 12,
                            Nombre = "Horror",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 13,
                            Nombre = "Música",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 14,
                            Nombre = "Misterio",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 15,
                            Nombre = "Romance",
                            Protegida = true
                        });
                });

            modelBuilder.Entity("backendnet.Models.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Protegido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2288571e-d274-4682-85ea-70655d1a6e9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "141cbac1-1cd7-4cc5-877e-6f4ebde3422c",
                            Email = "antonio@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "José Antonio Espinoza Rodríguez",
                            NormalizedEmail = "ANTONIO@UV.MX",
                            NormalizedUserName = "ANTONIO@.UV.MX",
                            PasswordHash = "AQAAAAIAAYagAAAAELxu273KS+tSEybdVIVoyRaWnCEvRBmCYJtaa6dogaUesarFvsCebpD39NVtTchdMg==",
                            PhoneNumberConfirmed = false,
                            Protegido = true,
                            SecurityStamp = "c310acf3-578e-4a05-b494-4d71c5c885f3",
                            TwoFactorEnabled = false,
                            UserName = "antonio@uv.mx"
                        },
                        new
                        {
                            Id = "b11a2cff-aece-4063-bae7-3ce1674f0c9a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ebe7a097-9413-44f8-8bae-9d2a46879485",
                            Email = "charles@uv.mx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nombre = "Usuario Charles",
                            NormalizedEmail = "CHARLES@UV.MX",
                            NormalizedUserName = "CHARLES@.UV.MX",
                            PasswordHash = "AQAAAAIAAYagAAAAEBFkGQK7GBmagLSDhA+ugF2bAjEMywxxQsd3iCSq1IN5J4P9mfOzXLTr7nVpJcHeQA==",
                            PhoneNumberConfirmed = false,
                            Protegido = true,
                            SecurityStamp = "e33247c6-725c-4e70-b8d1-fdaec7db27a6",
                            TwoFactorEnabled = false,
                            UserName = "charles@uv.mx"
                        });
                });

            modelBuilder.Entity("backendnet.Models.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PeliculaId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PeliculaId");

                    b.ToTable("Pelicula");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Andrew Dufresne es un hombre inocente que es acusado del asesinato de su mujer. Tras ser condenado a cadena perpetua, es enviado a la cárcel de Shawshank, en Maine. Con el paso de los años, Andrew conseguirá ganarse la confianza del director del centro y el respeto de los otros convictos, especialmente de Red, el jefe de la mafia.",
                            Titulo = "Sueño de fuga"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Don Vito Corleone es el respetado y temido jefe de una de las cinco familias de la mafia de Nueva York en los años 40. El hombre tiene cuatro hijos: Connie, Sonny, Fredo y Michael, que no quiere saber nada de los negocios sucios de su padre. Cuando otro capo, Sollozzo, intenta asesinar a Corleone, empieza una cruenta lucha entre los distintos clanes.",
                            Titulo = "El padrino"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Con la ayuda del teniente Jim Gordon y del Fiscal del Distrito Harvey Dent, Batman mantiene a raya el crimen organizado en Gotham. Todo cambia cuando aparece el Joker, un nuevo criminal que desencadena el caos y tiene aterrados a los ciudadanos.",
                            Titulo = "El caballero oscuro"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "La batalla por la Tierra Media ha empezado. Las fuerzas de Saruman han sido destruidas y por primera vez parece que hay una pequeña esperanza. Sin embargo, el poder de Sauron crece y su interés se centra en Gondor, el último reducto de los hombres, cuyo heredero es Aragorn. Mientras, Frodo y Sam, guiados por Gollum, siguen su peligrosa misión a través de Mordor para destruir el anillo.",
                            Titulo = "El retorno del rey"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "La vida de un boxeador, dos sicarios, la esposa de un gánster y dos bandidos se entrelaza en una historia de violencia y redención.",
                            Titulo = "Tiempos violentos"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Sentado en un banco en Savannah, Georgia, Forrest Gump espera al autobús. Mientras éste tarda en llegar, el joven cuenta su vida a las personas que se sientan a esperar con él. Aunque sufre un pequeño retraso mental, esto no le impide hacer cosas maravillosas. Sin entender del todo lo que sucede a su alrededor, Forrest toma partido en los eventos más importantes de la historia de los Estados Unidos.",
                            Titulo = "Forrest Gump"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Un empleado de oficina insomne, harto de su vida, se cruza con un vendedor peculiar. Ambos crean un club de lucha clandestino como forma de terapia y, poco a poco, la organización crece y sus objetivos toman otro rumbo.",
                            Titulo = "El club de la pelea"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Dom Cobb (Leonardo DiCaprio) es un ladrón con una extraña habilidad para entrar a los sueños de la gente y robarle los secretos de sus subconscientes. Su habilidad lo ha convertido en un atractivo en el mundo del espionaje corporativo, pero ha tenido un gran costo en la gente que ama. Cobb tiene la oportunidad de ser perdonado cuando recibe una tarea imposible: plantar una idea en la mente de una persona. Si tiene éxito, será el crimen perfecto, pero un enemigo se anticipa a sus movimientos.",
                            Titulo = "Inception"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "",
                            Titulo = "Star Wars: Episodio V - El imperio Contrataca"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Son tiempos adversos para la rebelión. Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Tras escapar de la terrible Flota Imperial, un grupo de guerreros de la libertad, encabezados por Luke Skywalker, ha establecido una nueva base secreta en el remonto mundo helado de Hoth.",
                            Titulo = "Matrix"
                        },
                        new
                        {
                            PeliculaId = 11,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Un grupo de científicos y exploradores, encabezados por Cooper, se embarcan en un viaje espacial para encontrar un lugar con las condiciones necesarias para reemplazar a la Tierra y comenzar una nueva vida allí. La Tierra está llegando a su fin y este grupo necesita encontrar un planeta más allá de nuestra galaxia que garantice el futuro de la raza humana.",
                            Titulo = "Interestelar"
                        },
                        new
                        {
                            PeliculaId = 12,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Paul Atreides se une a Chani y a los Fremen mientras busca venganza contra los conspiradores que destruyeron a su familia. Paul se enfrenta a una elección entre el amor de su vida y el destino del universo, y debe evitar un futuro terrible.",
                            Titulo = "Dune: Parte dos"
                        },
                        new
                        {
                            PeliculaId = 13,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Algunos años antes, un viajero del tiempo le reveló a la madre de John que su hijo sería el salvador de la humanidad. Cuando un nuevo androide mejorado llega del futuro para asesinar a John, un viejo modelo será enviado para protegerle.",
                            Titulo = "Terminator 2: El juicio final"
                        },
                        new
                        {
                            PeliculaId = 14,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Doc vuelve a aparecer con una máquina del tiempo mucho más modernizada y le pide a Marty y a su novia que le acompañen al futuro. En el Hill Valley de 2015 deberán solucionar un problema con la ley que tendrá uno de los futuros hijos de Marty y Jenny. En el futuro, Biff Tannen roba la máquina del tiempo y vuelve al pasado para darle a su hijo un libro con estadísticas deportivas para poder ganar una enorme fortuna en las apuestas. Marty y Doc tendrán que parar la posible catástrofe del destino.",
                            Titulo = "Volver al futuro"
                        },
                        new
                        {
                            PeliculaId = 15,
                            Anio = 0,
                            Poster = "N/A",
                            Sinopsis = "Después de ser expulsada de Barbieland por no ser una muñeca de aspecto perfecto, Barbie parte hacia el mundo humano para encontrar la verdadera felicidad.",
                            Titulo = "Barbie"
                        });
                });

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.HasOne("backendnet.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasPeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("backendnet.Models.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
