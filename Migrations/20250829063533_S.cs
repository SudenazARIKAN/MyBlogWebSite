using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travelproject.Migrations
{
    /// <inheritdoc />
    public partial class S : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MyBlogs_BlogID",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyBlogs",
                table: "MyBlogs");

            migrationBuilder.RenameTable(
                name: "MyBlogs",
                newName: "MyBlog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyBlog",
                table: "MyBlog",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MyBlog_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "MyBlog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MyBlog_BlogID",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyBlog",
                table: "MyBlog");

            migrationBuilder.RenameTable(
                name: "MyBlog",
                newName: "MyBlogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyBlogs",
                table: "MyBlogs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MyBlogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "MyBlogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
