using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7d251cd2-9e56-462a-99f2-c1f42f8bc097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398"));

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookPublishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPublishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookPublishers_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPublishers_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Admin", null },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Read", null },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Write", null },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Create", null },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Update", null },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Delete", null },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Admin", null },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Read", null },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Write", null },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Create", null },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Update", null },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookPublishers.Delete", null },
                    { 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Admin", null },
                    { 151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Read", null },
                    { 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Write", null },
                    { 153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Create", null },
                    { 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Update", null },
                    { 155, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 221, 9, 39, 34, 60, 57, 217, 180, 18, 181, 241, 203, 205, 145, 109, 149, 21, 155, 76, 0, 70, 216, 55, 244, 66, 180, 232, 93, 57, 196, 51, 118, 89, 12, 242, 146, 37, 80, 211, 12, 198, 112, 21, 61, 235, 201, 29, 168, 233, 194, 31, 106, 159, 181, 39, 90, 229, 226, 194, 60, 145, 115, 10, 68 }, new byte[] { 58, 243, 134, 66, 77, 155, 106, 247, 103, 194, 62, 188, 96, 241, 27, 79, 167, 231, 16, 210, 144, 237, 253, 140, 37, 29, 195, 58, 129, 166, 230, 213, 99, 106, 177, 200, 169, 14, 42, 227, 72, 173, 197, 96, 212, 123, 80, 114, 234, 195, 188, 82, 120, 245, 5, 198, 48, 125, 176, 131, 224, 137, 88, 206, 87, 52, 74, 153, 22, 28, 72, 172, 125, 56, 32, 189, 48, 209, 249, 113, 139, 206, 78, 233, 229, 82, 119, 13, 17, 136, 163, 188, 207, 4, 94, 31, 102, 204, 6, 181, 42, 148, 72, 194, 37, 149, 37, 164, 193, 171, 193, 48, 3, 40, 28, 100, 21, 174, 1, 201, 68, 195, 186, 9, 18, 94, 61, 196 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4ac5e5e6-bc7a-48c8-be45-1f42dddb3a54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05") });

            migrationBuilder.CreateIndex(
                name: "IX_BookPublishers_BookId",
                table: "BookPublishers",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPublishers_PublisherId",
                table: "BookPublishers",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookPublishers");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4ac5e5e6-bc7a-48c8-be45-1f42dddb3a54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33ae9e05-7130-42b1-994b-6a0ce17e6f05"));

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 56, 154, 4, 137, 170, 78, 247, 21, 63, 136, 183, 180, 112, 69, 99, 64, 70, 199, 179, 220, 134, 35, 183, 110, 144, 120, 206, 246, 230, 4, 106, 109, 29, 102, 9, 213, 95, 158, 28, 133, 240, 43, 59, 86, 163, 26, 201, 248, 31, 72, 216, 91, 179, 92, 58, 197, 57, 231, 201, 132, 77, 86, 6, 24 }, new byte[] { 198, 87, 138, 202, 204, 108, 198, 140, 188, 158, 218, 53, 93, 17, 190, 243, 22, 34, 102, 35, 136, 255, 180, 203, 187, 97, 96, 90, 231, 101, 11, 70, 48, 124, 0, 4, 141, 204, 231, 10, 222, 32, 221, 11, 173, 151, 178, 84, 59, 204, 169, 163, 121, 34, 103, 55, 111, 127, 126, 67, 184, 13, 72, 247, 38, 48, 147, 177, 182, 216, 7, 185, 3, 251, 174, 46, 113, 214, 170, 191, 246, 167, 180, 61, 113, 93, 79, 107, 193, 206, 94, 23, 106, 63, 111, 47, 152, 155, 150, 45, 55, 145, 59, 244, 193, 155, 224, 63, 208, 246, 214, 116, 71, 102, 198, 204, 59, 133, 223, 190, 241, 8, 77, 195, 78, 155, 90, 235 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7d251cd2-9e56-462a-99f2-c1f42f8bc097"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8b938800-f2f4-466d-84cb-6f6a2326e398") });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
