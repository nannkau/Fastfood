using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fastfood1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhacungcap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Diachi = table.Column<string>(nullable: true),
                    Sodienthoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhacungcap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    Sodienthoai = table.Column<string>(nullable: true),
                    Gioitinh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taikhoan = table.Column<string>(nullable: true),
                    Matkhau = table.Column<string>(nullable: true),
                    Trangthai = table.Column<int>(nullable: false),
                    Quyen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Monan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true),
                    GiaMua = table.Column<int>(nullable: false),
                    GiaBan = table.Column<int>(nullable: false),
                    Soluong = table.Column<int>(nullable: false),
                    NhacungcapID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Monan_Nhacungcap_NhacungcapID",
                        column: x => x.NhacungcapID,
                        principalTable: "Nhacungcap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hoadon",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaylap = table.Column<DateTime>(nullable: false),
                    Tongtien = table.Column<int>(nullable: false),
                    NhanvienID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hoadon_Nhanvien_NhanvienID",
                        column: x => x.NhanvienID,
                        principalTable: "Nhanvien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phieunhap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tongtien = table.Column<int>(nullable: false),
                    Ngaylap = table.Column<DateTime>(nullable: false),
                    NhanvienID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieunhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Phieunhap_Nhanvien_NhanvienID",
                        column: x => x.NhanvienID,
                        principalTable: "Nhanvien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chitiethoadon",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soluong = table.Column<int>(nullable: false),
                    MonanID = table.Column<int>(nullable: true),
                    HoadonID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiethoadon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chitiethoadon_Hoadon_HoadonID",
                        column: x => x.HoadonID,
                        principalTable: "Hoadon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitiethoadon_Monan_MonanID",
                        column: x => x.MonanID,
                        principalTable: "Monan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chitietphieunhap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soluong = table.Column<int>(nullable: false),
                    MonanID = table.Column<int>(nullable: true),
                    PhieunhapID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietphieunhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chitietphieunhap_Monan_MonanID",
                        column: x => x.MonanID,
                        principalTable: "Monan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietphieunhap_Phieunhap_PhieunhapID",
                        column: x => x.PhieunhapID,
                        principalTable: "Phieunhap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadon_HoadonID",
                table: "Chitiethoadon",
                column: "HoadonID");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadon_MonanID",
                table: "Chitiethoadon",
                column: "MonanID");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietphieunhap_MonanID",
                table: "Chitietphieunhap",
                column: "MonanID");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietphieunhap_PhieunhapID",
                table: "Chitietphieunhap",
                column: "PhieunhapID");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_NhanvienID",
                table: "Hoadon",
                column: "NhanvienID");

            migrationBuilder.CreateIndex(
                name: "IX_Monan_NhacungcapID",
                table: "Monan",
                column: "NhacungcapID");

            migrationBuilder.CreateIndex(
                name: "IX_Phieunhap_NhanvienID",
                table: "Phieunhap",
                column: "NhanvienID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiethoadon");

            migrationBuilder.DropTable(
                name: "Chitietphieunhap");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Hoadon");

            migrationBuilder.DropTable(
                name: "Monan");

            migrationBuilder.DropTable(
                name: "Phieunhap");

            migrationBuilder.DropTable(
                name: "Nhacungcap");

            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}
