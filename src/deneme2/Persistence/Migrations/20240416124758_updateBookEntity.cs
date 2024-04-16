using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateBookEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e8f8ab34-3ac2-42a0-b18a-3f0337ea62b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Page",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "UnitsInStock",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 139, 91, 32, 45, 211, 93, 72, 42, 29, 25, 132, 253, 18, 234, 22, 204, 241, 137, 112, 206, 224, 91, 25, 153, 141, 228, 4, 27, 214, 162, 47, 10, 171, 21, 101, 215, 196, 107, 172, 211, 150, 39, 147, 36, 141, 210, 123, 23, 88, 163, 152, 120, 148, 14, 0, 111, 158, 0, 155, 121, 227, 220, 104, 177 }, new byte[] { 1, 19, 10, 6, 245, 157, 183, 123, 38, 93, 70, 148, 16, 59, 250, 216, 64, 120, 184, 61, 35, 179, 181, 125, 83, 182, 53, 170, 244, 109, 191, 84, 146, 94, 10, 61, 12, 205, 110, 228, 62, 16, 196, 45, 50, 6, 90, 237, 160, 107, 230, 11, 36, 221, 86, 184, 92, 24, 27, 71, 247, 236, 246, 116, 168, 164, 154, 190, 20, 63, 34, 48, 187, 19, 154, 7, 163, 82, 74, 146, 180, 7, 193, 91, 21, 175, 43, 122, 157, 158, 235, 27, 166, 7, 248, 236, 103, 91, 229, 77, 77, 163, 167, 63, 221, 240, 84, 249, 246, 36, 78, 170, 35, 80, 132, 125, 159, 9, 238, 149, 142, 136, 148, 136, 162, 134, 24, 167 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("dece5162-89fd-4591-a422-d01315c4dbaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("dece5162-89fd-4591-a422-d01315c4dbaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Page",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UnitsInStock",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 133, 193, 37, 121, 36, 73, 24, 111, 157, 86, 82, 7, 174, 40, 23, 28, 187, 46, 81, 170, 165, 215, 4, 248, 112, 62, 40, 146, 221, 69, 54, 200, 227, 153, 0, 111, 239, 43, 222, 163, 202, 226, 203, 249, 122, 176, 202, 140, 197, 96, 41, 60, 207, 4, 140, 44, 27, 48, 188, 50, 102, 32, 69, 57 }, new byte[] { 95, 15, 207, 75, 81, 79, 55, 129, 254, 238, 228, 220, 68, 254, 184, 98, 109, 145, 162, 13, 56, 240, 54, 192, 202, 126, 26, 115, 203, 248, 74, 199, 22, 92, 239, 224, 117, 71, 253, 174, 174, 188, 136, 54, 180, 7, 143, 125, 81, 7, 83, 150, 223, 4, 168, 78, 89, 130, 59, 169, 151, 39, 253, 64, 33, 8, 21, 203, 233, 171, 220, 254, 88, 51, 22, 157, 77, 222, 123, 145, 223, 207, 173, 44, 118, 44, 171, 37, 55, 233, 199, 247, 39, 83, 226, 74, 57, 38, 5, 89, 21, 82, 133, 131, 145, 54, 2, 110, 16, 169, 4, 43, 190, 30, 137, 46, 192, 229, 169, 21, 113, 93, 105, 10, 124, 192, 132, 162 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e8f8ab34-3ac2-42a0-b18a-3f0337ea62b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("041ec3fb-4911-4b8c-b0c5-3ba08ebfc759") });
        }
    }
}
