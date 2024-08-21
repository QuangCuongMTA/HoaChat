using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoaChat.Migrations
{
    /// <inheritdoc />
    public partial class DbHoaChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiHoaChat",
                columns: table => new
                {
                    iDLoaiHC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loaiHC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHoaChat", x => x.iDLoaiHC);
                });

            migrationBuilder.CreateTable(
                name: "HoaChat",
                columns: table => new
                {
                    idHoaChat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHoaChat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    khaiNiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    xamNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trieuChung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mucDich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phuongTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phuongPhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iDLoaiHC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaChat", x => x.idHoaChat);
                    table.ForeignKey(
                        name: "FK_HoaChat_LoaiHoaChat_iDLoaiHC",
                        column: x => x.iDLoaiHC,
                        principalTable: "LoaiHoaChat",
                        principalColumn: "iDLoaiHC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    idAnh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idHoaChat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.idAnh);
                    table.ForeignKey(
                        name: "FK_Anh_HoaChat_idHoaChat",
                        column: x => x.idHoaChat,
                        principalTable: "HoaChat",
                        principalColumn: "idHoaChat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    idVideo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idHoaChat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.idVideo);
                    table.ForeignKey(
                        name: "FK_Video_HoaChat_idHoaChat",
                        column: x => x.idHoaChat,
                        principalTable: "HoaChat",
                        principalColumn: "idHoaChat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anh_idHoaChat",
                table: "Anh",
                column: "idHoaChat");

            migrationBuilder.CreateIndex(
                name: "IX_HoaChat_iDLoaiHC",
                table: "HoaChat",
                column: "iDLoaiHC");

            migrationBuilder.CreateIndex(
                name: "IX_Video_idHoaChat",
                table: "Video",
                column: "idHoaChat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "HoaChat");

            migrationBuilder.DropTable(
                name: "LoaiHoaChat");
        }
    }
}
