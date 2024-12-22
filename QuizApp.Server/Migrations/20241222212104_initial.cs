using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pregunta",
                table: "Questions",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "Opciones",
                table: "Questions",
                newName: "Option4");

            migrationBuilder.RenameColumn(
                name: "OpcionCorrecta",
                table: "Questions",
                newName: "CorrectOption");

            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option3",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Option3",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Questions",
                newName: "Pregunta");

            migrationBuilder.RenameColumn(
                name: "Option4",
                table: "Questions",
                newName: "Opciones");

            migrationBuilder.RenameColumn(
                name: "CorrectOption",
                table: "Questions",
                newName: "OpcionCorrecta");
        }
    }
}
