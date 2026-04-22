using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompany.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B43BDB0A-200B-4BFE-A258-94526382AE01",
                column: "ConcurrencyStamp",
                value: "aad41b1b-804e-4aff-9004-3a035edab623");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BE6DF0E3-8271-4D00-84AD-6E7C5AB0E970",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29b1729c-49b1-4169-9b4d-c50e09cb324d", "AQAAAAIAAYagAAAAEAn/12wlrd1Q8saziXxacxc5l2T2BCK5ohPnuGAYqKY9pYBWMedK9wQhZLXUVuaiQA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B43BDB0A-200B-4BFE-A258-94526382AE01",
                column: "ConcurrencyStamp",
                value: "45b64518-938c-4178-af6f-bf5239738ea8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BE6DF0E3-8271-4D00-84AD-6E7C5AB0E970",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c386d29-880f-427e-8232-791b5aec9eb0", "AQAAAAIAAYagAAAAEAReODMcER9mrNcice27ZNy+ZFzKNE9DHEJxAlmhvX+gcXILVrHPW70i4TldOJiH4g==" });
        }
    }
}
