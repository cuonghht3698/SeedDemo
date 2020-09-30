using Microsoft.EntityFrameworkCore.Migrations;

namespace Day1.Migrations
{
    public partial class AddSeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Taikhoan",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1121, "cuaodkas" });

            migrationBuilder.InsertData(
                table: "Taikhoan",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11221, "cuong bAAro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 11221);
        }
    }
}
