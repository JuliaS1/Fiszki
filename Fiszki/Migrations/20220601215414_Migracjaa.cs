using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiszki.Migrations
{
    public partial class Migracjaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fiszkiii",
                columns: new[] { "id_fiszki", "Done", "Kategoria", "Nazwa_fiszki", "Opis", "Przedmiot", "Zrobione" },
                values: new object[] { 5, false, "ijgfd", "sdfghj", "sdfghjkljfdsfghjkmhg", "hjgytfrds", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fiszkiii",
                keyColumn: "id_fiszki",
                keyValue: 5);
        }
    }
}
