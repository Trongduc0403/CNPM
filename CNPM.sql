USE [master]
GO
/****** Object:  Database [CNPM]    Script Date: 13/01/2021 9:42:51 AM ******/
CREATE DATABASE [CNPM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CNPM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CNPM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CNPM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CNPM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CNPM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CNPM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CNPM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CNPM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CNPM] SET ARITHABORT OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CNPM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CNPM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CNPM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CNPM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CNPM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CNPM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CNPM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CNPM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CNPM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CNPM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CNPM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CNPM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CNPM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CNPM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CNPM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CNPM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CNPM] SET  MULTI_USER 
GO
ALTER DATABASE [CNPM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CNPM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CNPM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CNPM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CNPM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CNPM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CNPM] SET QUERY_STORE = OFF
GO
USE [CNPM]
GO
/****** Object:  Table [dbo].[BBGN]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BBGN](
	[idBBGN] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NULL,
	[idKH] [int] NULL,
	[idNV] [int] NULL,
	[NgayGiao] [datetime] NULL,
	[KmDi] [int] NULL,
	[XangDi] [char](20) NULL,
	[TrangThaiDi] [nvarchar](100) NULL,
	[KmVe] [int] NULL,
	[XangVe] [char](20) NULL,
	[TrangThaiVe] [nvarchar](100) NULL,
 CONSTRAINT [PK_Table_6] PRIMARY KEY CLUSTERED 
(
	[idBBGN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BBSC]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BBSC](
	[idBBSC] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NULL,
	[idKH] [int] NULL,
	[idNV] [int] NULL,
	[TenSC] [nvarchar](50) NULL,
	[NgayBBSC] [datetime] NULL,
	[NoiDungSC] [nvarchar](100) NULL,
	[TienPhat] [char](11) NULL,
 CONSTRAINT [PK_Table_7] PRIMARY KEY CLUSTERED 
(
	[idBBSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[idHopDong] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NULL,
	[idKH] [int] NULL,
	[idNV] [int] NULL,
	[NgayHD] [datetime] NULL,
	[NoiDungHD] [nvarchar](1000) NULL,
	[TienDat] [char](11) NULL,
	[KhuyenMai] [char](11) NULL,
	[GiayToGiuLai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_5] PRIMARY KEY CLUSTERED 
(
	[idHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[sdtKH] [char](11) NULL,
	[cmtKH] [char](11) NULL,
	[GPLX] [char](11) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[idKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[idLoaiXe] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_3] PRIMARY KEY CLUSTERED 
(
	[idLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[VaiTro] [nvarchar](50) NULL,
	[cmtNV] [char](11) NULL,
	[sdtNV] [char](11) NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[idHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[idHopDong] [int] NULL,
	[idNV] [int] NULL,
	[NgayTT] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
	[HoSoKem] [nvarchar](50) NULL,
	[TienTT] [char](11) NULL,
 CONSTRAINT [PK_ThanhToan] PRIMARY KEY CLUSTERED 
(
	[idHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 13/01/2021 9:42:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[idXe] [int] IDENTITY(1,1) NOT NULL,
	[idLoaiXe] [int] NULL,
	[TenXe] [nvarchar](50) NULL,
	[PhiXang] [char](11) NULL,
	[PhiQuaKm] [char](11) NULL,
	[DonGia] [char](11) NULL,
	[MoTaTT] [nvarchar](100) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_Table_4] PRIMARY KEY CLUSTERED 
(
	[idXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([idKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (1, N'Trần Ngọc Hoàng', N'Thủ Đức', N'0946987467 ', N'197569874  ', N'6548942123 ')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (2, N'Võ Xuân Tú', N'Quận 9', N'0648746789 ', N'197846789  ', N'4654987787 ')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [DiaChi], [sdtKH], [cmtKH], [GPLX]) VALUES (3, N'Lê Phước Đạt', N'Bình Dương', N'0978976487 ', N'197446789  ', N'0498465487 ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiXe] ON 

INSERT [dbo].[LoaiXe] ([idLoaiXe], [TenLoai], [SoLuong], [MoTa]) VALUES (1, N'Toyota', 2, N'Mới ')
INSERT [dbo].[LoaiXe] ([idLoaiXe], [TenLoai], [SoLuong], [MoTa]) VALUES (2, N'Huyndai', 3, N'Mới ')
INSERT [dbo].[LoaiXe] ([idLoaiXe], [TenLoai], [SoLuong], [MoTa]) VALUES (3, N'Mazda', 2, N'Mới ')
SET IDENTITY_INSERT [dbo].[LoaiXe] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([idNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (1, N'Phan Nguyễn Trọng Đức', N'Giám đốc', N'197454194  ', N'0942663145 ')
INSERT [dbo].[NhanVien] ([idNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (2, N'Đinh Trọng Khanh', N'Kế toán', N'197458745  ', N'0914569845 ')
INSERT [dbo].[NhanVien] ([idNV], [TenNV], [VaiTro], [cmtNV], [sdtNV]) VALUES (3, N'Nguyễn Hoàng Long', N'Sửa chữa', N'197648945  ', N'0948762456 ')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (1, 1, N'Toyota Vios ', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (2, 2, N'Hyundai Elantra 2020', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (3, 2, N'Hyundai Accent 2021', N'17000      ', N'20000      ', N'500000     ', N'Còn mới', 0)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (4, 1, N'Toyota Fortuner', N'18000      ', N'25000      ', N'600000     ', N'Còn mới', 0)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (5, 3, N'Mazda 6', N'20000      ', N'25000      ', N'700000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (6, 3, N'Mazda CX5', N'21000      ', N'25000      ', N'800000     ', N'Còn mới', 1)
INSERT [dbo].[Xe] ([idXe], [idLoaiXe], [TenXe], [PhiXang], [PhiQuaKm], [DonGia], [MoTaTT], [TrangThai]) VALUES (7, 2, N'Hyundai Santafe 2020', N'20000      ', N'25000      ', N'700000     ', N'Còn mới', 1)
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_Table_6_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_Table_6_KhachHang]
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_Table_6_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_Table_6_Table_2]
GO
ALTER TABLE [dbo].[BBGN]  WITH CHECK ADD  CONSTRAINT [FK_Table_6_Table_6] FOREIGN KEY([idBBGN])
REFERENCES [dbo].[BBGN] ([idBBGN])
GO
ALTER TABLE [dbo].[BBGN] CHECK CONSTRAINT [FK_Table_6_Table_6]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_Table_7_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_Table_7_KhachHang]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_Table_7_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_Table_7_Table_2]
GO
ALTER TABLE [dbo].[BBSC]  WITH CHECK ADD  CONSTRAINT [FK_Table_7_Table_4] FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([idXe])
GO
ALTER TABLE [dbo].[BBSC] CHECK CONSTRAINT [FK_Table_7_Table_4]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_KhachHang]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_Table_2]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_5_Table_4] FOREIGN KEY([idXe])
REFERENCES [dbo].[Xe] ([idXe])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_Table_5_Table_4]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_Table_2] FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_Table_2]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_Table_5] FOREIGN KEY([idHopDong])
REFERENCES [dbo].[HopDong] ([idHopDong])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_Table_5]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Table_4_Table_3] FOREIGN KEY([idLoaiXe])
REFERENCES [dbo].[LoaiXe] ([idLoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Table_4_Table_3]
GO
USE [master]
GO
ALTER DATABASE [CNPM] SET  READ_WRITE 
GO
