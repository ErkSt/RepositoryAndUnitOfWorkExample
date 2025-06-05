using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestNetCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Title", "Content", "Author", "CreatedAt" },
                values: new object[,]
                {
                    { "Primer Post", "Contenido de ejemplo", "Admin", DateTime.UtcNow },
                    { "Segundo Post", "Otro contenido", "Admin", DateTime.UtcNow }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Title",
                keyValues: new object[]
                {
                    "Primer Post",
                    "Segundo Post"
                }
            );
        }
    }
}
