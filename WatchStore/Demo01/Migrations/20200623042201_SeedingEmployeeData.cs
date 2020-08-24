using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo01.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, "./images/anh trung.jpg", 0, "trung@gmail.com", "Trung Nguyen" },
                    { 2, "./images/quang.jpg", 1, "Quang@gmail.com", "Quang Nguyễn" },
                    { 3, "./images/trâm.png", 3, "tram@gmail.com", "Trâm Nguyễn" },
                    { 4, "./images/minh.jpg", 2, "minh@gmail.com", "Minh Nguyễn" },
                    { 5, "./images/chị ghi.jpg", 3, "ghi@gmail.com", "Ghi Nguyễn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
