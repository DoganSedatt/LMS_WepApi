using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c6c0c966-dce7-4dba-83e7-b89c1fa452bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23c67655-f66c-401f-bf96-e9d3c07a93f9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 56, 154, 4, 137, 170, 78, 247, 21, 63, 136, 183, 180, 112, 69, 99, 64, 70, 199, 179, 220, 134, 35, 183, 110, 144, 120, 206, 246, 230, 4, 106, 109, 29, 102, 9, 213, 95, 158, 28, 133, 240, 43, 59, 86, 163, 26, 201, 248, 31, 72, 216, 91, 179, 92, 58, 197, 57, 231, 201, 132, 77, 86, 6, 24 }, new byte[] { 198, 87, 138, 202, 204, 108, 198, 140, 188, 158, 218, 53, 93, 17, 190, 243, 22, 34, 102, 35, 136, 255, 180, 203, 187, 97, 96, 90, 231, 101, 11, 70, 48, 124, 0, 4, 141, 204, 231, 10, 222, 32, 221, 11, 173, 151, 178, 84, 59, 204, 169, 163, 121, 34, 103, 55, 111, 127, 126, 67, 184, 13, 72, 247, 38, 48, 147, 177, 182, 216, 7, 185, 3, 251, 174, 46, 113, 214, 170, 191, 246, 167, 180, 61, 113, 93, 79, 107, 193, 206, 94, 23, 106, 63, 111, 47, 152, 155, 150, 45, 55, 145, 59, 244, 193, 155, 224, 63, 208, 246, 214, 116, 71, 102, 198, 204, 59, 133, 223, 190, 241, 8, 77, 195, 78, 155, 90, 235 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7d251cd2-9e56-462a-99f2-c1f42f8bc097"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7d251cd2-9e56-462a-99f2-c1f42f8bc097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("23c67655-f66c-401f-bf96-e9d3c07a93f9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 140, 72, 135, 65, 76, 254, 202, 83, 191, 63, 46, 205, 228, 184, 104, 112, 153, 191, 229, 22, 72, 107, 238, 214, 144, 200, 100, 164, 148, 42, 164, 199, 66, 178, 237, 85, 187, 221, 60, 15, 249, 145, 23, 108, 223, 36, 27, 75, 203, 11, 130, 201, 80, 168, 138, 97, 233, 108, 5, 97, 1, 86, 158, 173 }, new byte[] { 186, 169, 117, 23, 67, 22, 144, 38, 128, 99, 28, 32, 219, 200, 174, 246, 197, 142, 103, 7, 227, 17, 8, 58, 100, 98, 4, 172, 159, 206, 249, 83, 202, 171, 206, 137, 191, 156, 86, 181, 183, 56, 244, 218, 111, 120, 49, 93, 119, 239, 60, 82, 214, 113, 246, 131, 190, 170, 145, 228, 47, 234, 130, 165, 43, 9, 188, 166, 3, 109, 29, 109, 53, 34, 227, 220, 129, 211, 10, 144, 142, 56, 141, 153, 178, 36, 58, 220, 132, 206, 124, 128, 38, 151, 71, 153, 243, 204, 110, 132, 26, 117, 10, 200, 16, 252, 220, 144, 113, 118, 30, 1, 28, 202, 78, 76, 58, 185, 79, 250, 235, 244, 214, 116, 70, 198, 117, 140 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c6c0c966-dce7-4dba-83e7-b89c1fa452bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("23c67655-f66c-401f-bf96-e9d3c07a93f9") });
        }
    }
}
