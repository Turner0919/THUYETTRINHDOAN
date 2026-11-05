using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorbikeServices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SyncQuyChuanXeNguoiDungModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuyChuanXeNguoiDungs_UserXes_UserXeId",
                table: "QuyChuanXeNguoiDungs");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyChuanXeNguoiDungs_UserXes_UserXeId",
                table: "QuyChuanXeNguoiDungs",
                column: "UserXeId",
                principalTable: "UserXes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuyChuanXeNguoiDungs_UserXes_UserXeId",
                table: "QuyChuanXeNguoiDungs");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyChuanXeNguoiDungs_UserXes_UserXeId",
                table: "QuyChuanXeNguoiDungs",
                column: "UserXeId",
                principalTable: "UserXes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
