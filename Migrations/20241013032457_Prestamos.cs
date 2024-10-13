using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SebastianSuarez_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class Prestamos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prestamo",
                keyColumn: "PrestamoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prestamo",
                keyColumn: "PrestamoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prestamo",
                keyColumn: "PrestamoId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Deudor",
                table: "Prestamo",
                newName: "Nombres");

            migrationBuilder.AlterColumn<int>(
                name: "Monto",
                table: "Prestamo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Concepto",
                table: "Prestamo",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeudorId",
                table: "Prestamo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Deudor",
                columns: table => new
                {
                    DeudorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeudorName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudor", x => x.DeudorId);
                });

            migrationBuilder.InsertData(
                table: "Deudor",
                columns: new[] { "DeudorId", "DeudorName" },
                values: new object[,]
                {
                    { 1, "Pedro" },
                    { 2, "Angel" },
                    { 3, "Diego" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deudor");

            migrationBuilder.DropColumn(
                name: "DeudorId",
                table: "Prestamo");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Prestamo",
                newName: "Deudor");

            migrationBuilder.AlterColumn<int>(
                name: "Monto",
                table: "Prestamo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Concepto",
                table: "Prestamo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Prestamo",
                columns: new[] { "PrestamoId", "Balance", "Concepto", "Deudor", "Monto" },
                values: new object[,]
                {
                    { 1, null, null, "Pedro", null },
                    { 2, null, null, "Angel", null },
                    { 3, null, null, "Diego", null }
                });
        }
    }
}
