using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.PeliculaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriaPelicula",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    PeliculasPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPelicula", x => new { x.CategoriasCategoriaId, x.PeliculasPeliculaId });
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Pelicula_PeliculasPeliculaId",
                        column: x => x.PeliculasPeliculaId,
                        principalTable: "Pelicula",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Acción", true },
                    { 2, "Aventura", true },
                    { 3, "Animación", true },
                    { 4, "Ciencia Ficción", true },
                    { 5, "Comedia", true },
                    { 6, "Crimen", true },
                    { 7, "Documental", true },
                    { 8, "Drama", true },
                    { 9, "Familiar", true },
                    { 10, "Fantasma", true },
                    { 11, "Historia", true },
                    { 12, "Horror", true },
                    { 13, "Música", true },
                    { 14, "Misterio", true },
                    { 15, "Romance", true }
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "PeliculaId", "Anio", "Poster", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 0, "N/A", "Andrew Dufresne es un hombre inocente que es acusado del asesinato de su mujer. Tras ser condenado a cadena perpetua, es enviado a la cárcel de Shawshank, en Maine. Con el paso de los años, Andrew conseguirá ganarse la confianza del director del centro y el respeto de los otros convictos, especialmente de Red, el jefe de la mafia.", "Sueño de fuga" },
                    { 2, 0, "N/A", "Don Vito Corleone es el respetado y temido jefe de una de las cinco familias de la mafia de Nueva York en los años 40. El hombre tiene cuatro hijos: Connie, Sonny, Fredo y Michael, que no quiere saber nada de los negocios sucios de su padre. Cuando otro capo, Sollozzo, intenta asesinar a Corleone, empieza una cruenta lucha entre los distintos clanes.", "El padrino" },
                    { 3, 0, "N/A", "Con la ayuda del teniente Jim Gordon y del Fiscal del Distrito Harvey Dent, Batman mantiene a raya el crimen organizado en Gotham. Todo cambia cuando aparece el Joker, un nuevo criminal que desencadena el caos y tiene aterrados a los ciudadanos.", "El caballero oscuro" },
                    { 4, 0, "N/A", "La batalla por la Tierra Media ha empezado. Las fuerzas de Saruman han sido destruidas y por primera vez parece que hay una pequeña esperanza. Sin embargo, el poder de Sauron crece y su interés se centra en Gondor, el último reducto de los hombres, cuyo heredero es Aragorn. Mientras, Frodo y Sam, guiados por Gollum, siguen su peligrosa misión a través de Mordor para destruir el anillo.", "El retorno del rey" },
                    { 5, 0, "N/A", "La vida de un boxeador, dos sicarios, la esposa de un gánster y dos bandidos se entrelaza en una historia de violencia y redención.", "Tiempos violentos" },
                    { 6, 0, "N/A", "Sentado en un banco en Savannah, Georgia, Forrest Gump espera al autobús. Mientras éste tarda en llegar, el joven cuenta su vida a las personas que se sientan a esperar con él. Aunque sufre un pequeño retraso mental, esto no le impide hacer cosas maravillosas. Sin entender del todo lo que sucede a su alrededor, Forrest toma partido en los eventos más importantes de la historia de los Estados Unidos.", "Forrest Gump" },
                    { 7, 0, "N/A", "Un empleado de oficina insomne, harto de su vida, se cruza con un vendedor peculiar. Ambos crean un club de lucha clandestino como forma de terapia y, poco a poco, la organización crece y sus objetivos toman otro rumbo.", "El club de la pelea" },
                    { 8, 0, "N/A", "Dom Cobb (Leonardo DiCaprio) es un ladrón con una extraña habilidad para entrar a los sueños de la gente y robarle los secretos de sus subconscientes. Su habilidad lo ha convertido en un atractivo en el mundo del espionaje corporativo, pero ha tenido un gran costo en la gente que ama. Cobb tiene la oportunidad de ser perdonado cuando recibe una tarea imposible: plantar una idea en la mente de una persona. Si tiene éxito, será el crimen perfecto, pero un enemigo se anticipa a sus movimientos.", "Inception" },
                    { 9, 0, "N/A", "", "Star Wars: Episodio V - El imperio Contrataca" },
                    { 10, 0, "N/A", "Son tiempos adversos para la rebelión. Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Tras escapar de la terrible Flota Imperial, un grupo de guerreros de la libertad, encabezados por Luke Skywalker, ha establecido una nueva base secreta en el remonto mundo helado de Hoth.", "Matrix" },
                    { 11, 0, "N/A", "Un grupo de científicos y exploradores, encabezados por Cooper, se embarcan en un viaje espacial para encontrar un lugar con las condiciones necesarias para reemplazar a la Tierra y comenzar una nueva vida allí. La Tierra está llegando a su fin y este grupo necesita encontrar un planeta más allá de nuestra galaxia que garantice el futuro de la raza humana.", "Interestelar" },
                    { 12, 0, "N/A", "Paul Atreides se une a Chani y a los Fremen mientras busca venganza contra los conspiradores que destruyeron a su familia. Paul se enfrenta a una elección entre el amor de su vida y el destino del universo, y debe evitar un futuro terrible.", "Dune: Parte dos" },
                    { 13, 0, "N/A", "Algunos años antes, un viajero del tiempo le reveló a la madre de John que su hijo sería el salvador de la humanidad. Cuando un nuevo androide mejorado llega del futuro para asesinar a John, un viejo modelo será enviado para protegerle.", "Terminator 2: El juicio final" },
                    { 14, 0, "N/A", "Doc vuelve a aparecer con una máquina del tiempo mucho más modernizada y le pide a Marty y a su novia que le acompañen al futuro. En el Hill Valley de 2015 deberán solucionar un problema con la ley que tendrá uno de los futuros hijos de Marty y Jenny. En el futuro, Biff Tannen roba la máquina del tiempo y vuelve al pasado para darle a su hijo un libro con estadísticas deportivas para poder ganar una enorme fortuna en las apuestas. Marty y Doc tendrán que parar la posible catástrofe del destino.", "Volver al futuro" },
                    { 15, 0, "N/A", "Después de ser expulsada de Barbieland por no ser una muñeca de aspecto perfecto, Barbie parte hacia el mundo humano para encontrar la verdadera felicidad.", "Barbie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPelicula_PeliculasPeliculaId",
                table: "CategoriaPelicula",
                column: "PeliculasPeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaPelicula");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pelicula");
        }
    }
}
