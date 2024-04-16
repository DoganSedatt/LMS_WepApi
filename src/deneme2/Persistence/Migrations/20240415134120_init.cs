using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4ac5e5e6-bc7a-48c8-be45-1f42dddb3a54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 5, 230, 61, 255, 137, 122, 157, 121, 191, 143, 36, 25, 187, 1, 168, 26, 96, 226, 120, 179, 172, 136, 21, 165, 26, 156, 144, 51, 234, 105, 243, 110, 34, 51, 108, 182, 201, 253, 147, 49, 144, 17, 215, 95, 250, 94, 20, 5, 230, 141, 136, 207, 149, 24, 149, 197, 59, 90, 27, 132, 97, 181, 30, 185 }, new byte[] { 86, 90, 96, 132, 168, 129, 254, 205, 8, 153, 171, 5, 97, 109, 97, 45, 0, 141, 230, 124, 197, 76, 21, 161, 158, 17, 120, 53, 11, 123, 56, 19, 73, 64, 195, 64, 20, 26, 72, 106, 67, 15, 132, 158, 1, 23, 130, 224, 187, 46, 160, 16, 169, 87, 198, 98, 186, 42, 202, 17, 6, 146, 217, 0, 108, 220, 77, 82, 227, 250, 219, 110, 140, 43, 2, 9, 254, 221, 71, 105, 186, 201, 126, 49, 132, 120, 190, 82, 86, 28, 79, 83, 225, 200, 250, 234, 116, 39, 135, 108, 195, 226, 85, 206, 221, 192, 210, 252, 143, 130, 11, 6, 16, 35, 146, 133, 174, 75, 249, 32, 36, 28, 63, 206, 245, 175, 13, 157 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1e33f5fc-ad3e-4c77-a7a7-0275f2f3fbe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1e33f5fc-ad3e-4c77-a7a7-0275f2f3fbe7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc78a894-638f-4e8d-a9a4-995ff8750a5d"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 221, 9, 39, 34, 60, 57, 217, 180, 18, 181, 241, 203, 205, 145, 109, 149, 21, 155, 76, 0, 70, 216, 55, 244, 66, 180, 232, 93, 57, 196, 51, 118, 89, 12, 242, 146, 37, 80, 211, 12, 198, 112, 21, 61, 235, 201, 29, 168, 233, 194, 31, 106, 159, 181, 39, 90, 229, 226, 194, 60, 145, 115, 10, 68 }, new byte[] { 58, 243, 134, 66, 77, 155, 106, 247, 103, 194, 62, 188, 96, 241, 27, 79, 167, 231, 16, 210, 144, 237, 253, 140, 37, 29, 195, 58, 129, 166, 230, 213, 99, 106, 177, 200, 169, 14, 42, 227, 72, 173, 197, 96, 212, 123, 80, 114, 234, 195, 188, 82, 120, 245, 5, 198, 48, 125, 176, 131, 224, 137, 88, 206, 87, 52, 74, 153, 22, 28, 72, 172, 125, 56, 32, 189, 48, 209, 249, 113, 139, 206, 78, 233, 229, 82, 119, 13, 17, 136, 163, 188, 207, 4, 94, 31, 102, 204, 6, 181, 42, 148, 72, 194, 37, 149, 37, 164, 193, 171, 193, 48, 3, 40, 28, 100, 21, 174, 1, 201, 68, 195, 186, 9, 18, 94, 61, 196 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4ac5e5e6-bc7a-48c8-be45-1f42dddb3a54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05") });
        }
    }
}
