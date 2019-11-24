﻿// <auto-generated />
using System;
using Fastfood1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fastfood1.Migrations
{
    [DbContext(typeof(FastfoodContext))]
    [Migration("20191124064637_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fastfood.Models.Chitiethoadon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HoadonID")
                        .HasColumnType("int");

                    b.Property<int?>("MonanID")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HoadonID");

                    b.HasIndex("MonanID");

                    b.ToTable("Chitiethoadon");
                });

            modelBuilder.Entity("Fastfood.Models.Chitietphieunhap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MonanID")
                        .HasColumnType("int");

                    b.Property<int?>("PhieunhapID")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MonanID");

                    b.HasIndex("PhieunhapID");

                    b.ToTable("Chitietphieunhap");
                });

            modelBuilder.Entity("Fastfood.Models.Hoadon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NhanvienID")
                        .HasColumnType("int");

                    b.Property<int>("Tongtien")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NhanvienID");

                    b.ToTable("Hoadon");
                });

            modelBuilder.Entity("Fastfood.Models.Monan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<int>("GiaMua")
                        .HasColumnType("int");

                    b.Property<string>("Loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NhacungcapID")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("NhacungcapID");

                    b.ToTable("Monan");
                });

            modelBuilder.Entity("Fastfood.Models.Nhacungcap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sodienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Nhacungcap");
                });

            modelBuilder.Entity("Fastfood.Models.Nhanvien", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sodienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("Fastfood.Models.Phieunhap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NhanvienID")
                        .HasColumnType("int");

                    b.Property<int>("Tongtien")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NhanvienID");

                    b.ToTable("Phieunhap");
                });

            modelBuilder.Entity("Fastfood.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Matkhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taikhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trangthai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Fastfood.Models.Chitiethoadon", b =>
                {
                    b.HasOne("Fastfood.Models.Hoadon", "Hoadon")
                        .WithMany()
                        .HasForeignKey("HoadonID");

                    b.HasOne("Fastfood.Models.Monan", "Monan")
                        .WithMany()
                        .HasForeignKey("MonanID");
                });

            modelBuilder.Entity("Fastfood.Models.Chitietphieunhap", b =>
                {
                    b.HasOne("Fastfood.Models.Monan", "Monan")
                        .WithMany()
                        .HasForeignKey("MonanID");

                    b.HasOne("Fastfood.Models.Phieunhap", "Phieunhap")
                        .WithMany()
                        .HasForeignKey("PhieunhapID");
                });

            modelBuilder.Entity("Fastfood.Models.Hoadon", b =>
                {
                    b.HasOne("Fastfood.Models.Nhanvien", "Nhanvien")
                        .WithMany()
                        .HasForeignKey("NhanvienID");
                });

            modelBuilder.Entity("Fastfood.Models.Monan", b =>
                {
                    b.HasOne("Fastfood.Models.Nhacungcap", "Nhacungcap")
                        .WithMany()
                        .HasForeignKey("NhacungcapID");
                });

            modelBuilder.Entity("Fastfood.Models.Phieunhap", b =>
                {
                    b.HasOne("Fastfood.Models.Nhanvien", "Nhanvien")
                        .WithMany()
                        .HasForeignKey("NhanvienID");
                });
#pragma warning restore 612, 618
        }
    }
}
