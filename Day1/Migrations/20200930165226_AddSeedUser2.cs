using Microsoft.EntityFrameworkCore.Migrations;

namespace Day1.Migrations
{
    public partial class AddSeedUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 11221);

            migrationBuilder.InsertData(
                table: "Taikhoan",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11282221, "cuaodkas" },
                    { 11222371, "cuong bAAro" },
                    { 1128221, "cuaoasfafafafafdkas" },
                    { 11832221, "cuong afafafafbAAro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 1128221);

            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 11222371);

            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 11282221);

            migrationBuilder.DeleteData(
                table: "Taikhoan",
                keyColumn: "Id",
                keyValue: 11832221);

            migrationBuilder.InsertData(
                table: "Taikhoan",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1121, "cuaodkas" });

            migrationBuilder.InsertData(
                table: "Taikhoan",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11221, "cuong bAAro" });
        }
    }
}
