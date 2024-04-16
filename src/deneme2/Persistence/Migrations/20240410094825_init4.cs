using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBooks_Books_BookId",
                table: "CategoryBooks");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b1eb8b7e-ec11-44a4-94fb-d44fa980422d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("977f58a8-b8a7-44bd-85fa-3b189cd1203b"));

            migrationBuilder.DropColumn(
                name: "BookdId",
                table: "CategoryBooks");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookId",
                table: "CategoryBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Admin", null },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Read", null },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Write", null },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Create", null },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Update", null },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Delete", null },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Admin", null },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Read", null },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Write", null },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Create", null },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Update", null },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Delete", null },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Admin", null },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Read", null },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Write", null },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Create", null },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Update", null },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("39e946d9-d6ec-4f77-9a0f-cb57f16de063"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 186, 69, 202, 50, 132, 68, 174, 171, 178, 157, 108, 202, 170, 42, 69, 201, 192, 195, 10, 215, 94, 168, 59, 158, 159, 67, 10, 23, 84, 0, 173, 149, 124, 58, 28, 87, 12, 167, 229, 49, 131, 244, 245, 65, 65, 247, 38, 251, 95, 10, 153, 14, 247, 26, 238, 131, 209, 156, 224, 252, 2, 17, 250, 122 }, new byte[] { 244, 255, 165, 132, 214, 101, 53, 149, 75, 73, 6, 92, 48, 84, 150, 188, 55, 32, 196, 171, 3, 175, 169, 90, 135, 186, 210, 109, 82, 220, 144, 196, 157, 21, 144, 128, 38, 13, 209, 53, 51, 146, 33, 93, 228, 136, 82, 186, 192, 234, 31, 251, 55, 65, 204, 228, 188, 19, 35, 254, 107, 126, 116, 244, 61, 125, 29, 90, 165, 108, 108, 77, 225, 165, 168, 69, 116, 194, 160, 49, 209, 10, 35, 240, 219, 135, 159, 130, 101, 16, 115, 230, 134, 17, 162, 151, 146, 64, 159, 41, 26, 190, 209, 86, 27, 214, 238, 178, 52, 61, 203, 59, 136, 219, 182, 93, 54, 115, 22, 22, 59, 74, 47, 128, 19, 96, 154, 162 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("24a03e21-f382-4f47-a6d0-7bc6a9a4a3c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("39e946d9-d6ec-4f77-9a0f-cb57f16de063") });

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_BookId",
                table: "Publishers",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBooks_Books_BookId",
                table: "CategoryBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBooks_Books_BookId",
                table: "CategoryBooks");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("24a03e21-f382-4f47-a6d0-7bc6a9a4a3c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e946d9-d6ec-4f77-9a0f-cb57f16de063"));

            migrationBuilder.AlterColumn<Guid>(
                name: "BookId",
                table: "CategoryBooks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "BookdId",
                table: "CategoryBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("977f58a8-b8a7-44bd-85fa-3b189cd1203b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 26, 249, 231, 96, 62, 191, 252, 151, 153, 5, 84, 194, 50, 38, 35, 50, 112, 134, 29, 174, 216, 172, 182, 0, 86, 206, 248, 41, 169, 87, 252, 68, 123, 12, 123, 29, 234, 114, 191, 144, 0, 198, 242, 233, 178, 220, 30, 200, 159, 169, 149, 104, 83, 154, 254, 134, 23, 243, 95, 212, 208, 191, 54, 134 }, new byte[] { 10, 200, 69, 4, 68, 89, 97, 176, 108, 239, 122, 168, 168, 249, 230, 65, 69, 126, 144, 208, 101, 224, 71, 249, 122, 139, 49, 121, 140, 92, 172, 88, 17, 215, 115, 88, 190, 235, 174, 11, 243, 8, 81, 200, 147, 105, 165, 180, 103, 36, 133, 111, 195, 11, 250, 110, 59, 238, 204, 6, 197, 165, 9, 117, 180, 39, 244, 35, 187, 114, 165, 44, 185, 69, 18, 209, 42, 135, 25, 131, 16, 177, 99, 108, 79, 238, 85, 99, 150, 61, 223, 103, 8, 71, 58, 203, 44, 227, 10, 200, 156, 131, 0, 86, 87, 199, 177, 182, 83, 251, 67, 45, 93, 63, 220, 110, 190, 183, 143, 109, 146, 4, 217, 148, 229, 242, 58, 254 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b1eb8b7e-ec11-44a4-94fb-d44fa980422d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("977f58a8-b8a7-44bd-85fa-3b189cd1203b") });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBooks_Books_BookId",
                table: "CategoryBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
