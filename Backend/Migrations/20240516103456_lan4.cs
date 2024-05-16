using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class lan4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "teacherInClasses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "studentInClasses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_teacherInClasses_TeacherId",
                table: "teacherInClasses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_studentInClasses_StudentId",
                table: "studentInClasses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentInClasses_students_StudentId",
                table: "studentInClasses",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teacherInClasses_teachers_TeacherId",
                table: "teacherInClasses",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentInClasses_students_StudentId",
                table: "studentInClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_teacherInClasses_teachers_TeacherId",
                table: "teacherInClasses");

            migrationBuilder.DropIndex(
                name: "IX_teacherInClasses_TeacherId",
                table: "teacherInClasses");

            migrationBuilder.DropIndex(
                name: "IX_studentInClasses_StudentId",
                table: "studentInClasses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "teacherInClasses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "studentInClasses");
        }
    }
}
