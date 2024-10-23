using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplexModelBinding.Data.Migrations
{
    /// <inheritdoc />
    public partial class troubleshootcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Courses",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                newName: "IX_Courses_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_TeacherId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Courses",
                newName: "InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                newName: "IX_Courses_InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
