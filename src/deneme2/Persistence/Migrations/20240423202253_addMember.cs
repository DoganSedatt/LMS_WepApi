using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("dece5162-89fd-4591-a422-d01315c4dbaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68"));

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Admin", null },
                    { 157, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Read", null },
                    { 158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Write", null },
                    { 159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Create", null },
                    { 160, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Update", null },
                    { 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d4f4b810-eb78-4a29-9015-a0cfcd286168"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 107, 63, 96, 16, 13, 190, 163, 141, 189, 212, 225, 255, 183, 113, 151, 15, 59, 4, 240, 174, 184, 21, 188, 82, 153, 66, 6, 121, 106, 196, 122, 76, 66, 180, 3, 203, 182, 217, 100, 77, 212, 231, 28, 179, 186, 114, 40, 7, 199, 43, 170, 100, 117, 120, 86, 149, 22, 77, 131, 252, 44, 246, 227, 72 }, new byte[] { 79, 99, 0, 82, 93, 88, 166, 212, 112, 168, 161, 197, 60, 187, 107, 50, 225, 230, 188, 70, 134, 20, 174, 255, 202, 193, 12, 148, 245, 59, 162, 127, 135, 139, 222, 48, 245, 162, 136, 212, 242, 16, 3, 247, 93, 65, 113, 124, 158, 254, 151, 25, 71, 60, 160, 155, 154, 58, 200, 119, 157, 27, 78, 36, 51, 117, 91, 173, 139, 88, 120, 180, 229, 227, 5, 12, 229, 59, 43, 72, 215, 203, 33, 105, 48, 202, 117, 1, 199, 171, 90, 246, 129, 58, 185, 166, 115, 204, 122, 134, 94, 255, 75, 225, 111, 241, 179, 126, 230, 25, 194, 229, 68, 54, 220, 85, 76, 237, 21, 20, 235, 141, 217, 194, 189, 73, 248, 197 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5cb49993-32fd-4dfc-b4f1-55d6a5dc75cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d4f4b810-eb78-4a29-9015-a0cfcd286168") });

            migrationBuilder.CreateIndex(
                name: "Member_UserID_UK",
                table: "Members",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5cb49993-32fd-4dfc-b4f1-55d6a5dc75cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4f4b810-eb78-4a29-9015-a0cfcd286168"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 139, 91, 32, 45, 211, 93, 72, 42, 29, 25, 132, 253, 18, 234, 22, 204, 241, 137, 112, 206, 224, 91, 25, 153, 141, 228, 4, 27, 214, 162, 47, 10, 171, 21, 101, 215, 196, 107, 172, 211, 150, 39, 147, 36, 141, 210, 123, 23, 88, 163, 152, 120, 148, 14, 0, 111, 158, 0, 155, 121, 227, 220, 104, 177 }, new byte[] { 1, 19, 10, 6, 245, 157, 183, 123, 38, 93, 70, 148, 16, 59, 250, 216, 64, 120, 184, 61, 35, 179, 181, 125, 83, 182, 53, 170, 244, 109, 191, 84, 146, 94, 10, 61, 12, 205, 110, 228, 62, 16, 196, 45, 50, 6, 90, 237, 160, 107, 230, 11, 36, 221, 86, 184, 92, 24, 27, 71, 247, 236, 246, 116, 168, 164, 154, 190, 20, 63, 34, 48, 187, 19, 154, 7, 163, 82, 74, 146, 180, 7, 193, 91, 21, 175, 43, 122, 157, 158, 235, 27, 166, 7, 248, 236, 103, 91, 229, 77, 77, 163, 167, 63, 221, 240, 84, 249, 246, 36, 78, 170, 35, 80, 132, 125, 159, 9, 238, 149, 142, 136, 148, 136, 162, 134, 24, 167 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("dece5162-89fd-4591-a422-d01315c4dbaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9ef1ba3b-48e5-48c1-bf7d-9ebd309c2c68") });
        }
    }
}
