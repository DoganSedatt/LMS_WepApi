using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addBookCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1e33f5fc-ad3e-4c77-a7a7-0275f2f3fbe7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 133, 193, 37, 121, 36, 73, 24, 111, 157, 86, 82, 7, 174, 40, 23, 28, 187, 46, 81, 170, 165, 215, 4, 248, 112, 62, 40, 146, 221, 69, 54, 200, 227, 153, 0, 111, 239, 43, 222, 163, 202, 226, 203, 249, 122, 176, 202, 140, 197, 96, 41, 60, 207, 4, 140, 44, 27, 48, 188, 50, 102, 32, 69, 57 }, new byte[] { 95, 15, 207, 75, 81, 79, 55, 129, 254, 238, 228, 220, 68, 254, 184, 98, 109, 145, 162, 13, 56, 240, 54, 192, 202, 126, 26, 115, 203, 248, 74, 199, 22, 92, 239, 224, 117, 71, 253, 174, 174, 188, 136, 54, 180, 7, 143, 125, 81, 7, 83, 150, 223, 4, 168, 78, 89, 130, 59, 169, 151, 39, 253, 64, 33, 8, 21, 203, 233, 171, 220, 254, 88, 51, 22, 157, 77, 222, 123, 145, 223, 207, 173, 44, 118, 44, 171, 37, 55, 233, 199, 247, 39, 83, 226, 74, 57, 38, 5, 89, 21, 82, 133, 131, 145, 54, 2, 110, 16, 169, 4, 43, 190, 30, 137, 46, 192, 229, 169, 21, 113, 93, 105, 10, 124, 192, 132, 162 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e8f8ab34-3ac2-42a0-b18a-3f0337ea62b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e8f8ab34-3ac2-42a0-b18a-3f0337ea62b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 5, 230, 61, 255, 137, 122, 157, 121, 191, 143, 36, 25, 187, 1, 168, 26, 96, 226, 120, 179, 172, 136, 21, 165, 26, 156, 144, 51, 234, 105, 243, 110, 34, 51, 108, 182, 201, 253, 147, 49, 144, 17, 215, 95, 250, 94, 20, 5, 230, 141, 136, 207, 149, 24, 149, 197, 59, 90, 27, 132, 97, 181, 30, 185 }, new byte[] { 86, 90, 96, 132, 168, 129, 254, 205, 8, 153, 171, 5, 97, 109, 97, 45, 0, 141, 230, 124, 197, 76, 21, 161, 158, 17, 120, 53, 11, 123, 56, 19, 73, 64, 195, 64, 20, 26, 72, 106, 67, 15, 132, 158, 1, 23, 130, 224, 187, 46, 160, 16, 169, 87, 198, 98, 186, 42, 202, 17, 6, 146, 217, 0, 108, 220, 77, 82, 227, 250, 219, 110, 140, 43, 2, 9, 254, 221, 71, 105, 186, 201, 126, 49, 132, 120, 190, 82, 86, 28, 79, 83, 225, 200, 250, 234, 116, 39, 135, 108, 195, 226, 85, 206, 221, 192, 210, 252, 143, 130, 11, 6, 16, 35, 146, 133, 174, 75, 249, 32, 36, 28, 63, 206, 245, 175, 13, 157 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1e33f5fc-ad3e-4c77-a7a7-0275f2f3fbe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d") });
        }
    }
}
