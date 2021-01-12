USE [Quanlythueoto]
GO
/****** Object:  Table [dbo].[BIENBANGN]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BIENBANGN](
	[Số BBGN] [char](10) NOT NULL,
	[Số xe] [char](10) NOT NULL,
	[Mã KH] [char](10) NOT NULL,
	[Mã NV] [char](10) NOT NULL,
	[Ngày giao] [datetime] NOT NULL,
	[Km đi] [int] NOT NULL,
	[Xăng đi] [char](20) NOT NULL,
	[Trạng thái đi] [nvarchar](100) NOT NULL,
	[Ngày nhận] [datetime] NOT NULL,
	[Km về] [int] NOT NULL,
	[Xăng về] [char](20) NOT NULL,
	[Trạng thái về] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BIENBANGN] PRIMARY KEY CLUSTERED 
(
	[Số BBGN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[Số HĐ] [char](10) NOT NULL,
	[Số xe] [char](10) NOT NULL,
	[Mã KH] [char](10) NOT NULL,
	[Mã NV] [char](10) NOT NULL,
	[Ngày HĐ] [datetime] NOT NULL,
	[Nội dung HĐ] [nvarchar](1000) NOT NULL,
	[Tiền đặt] [char](10) NOT NULL,
	[Khuyến mãi] [char](10) NOT NULL,
	[Giấy tờ giữ lại] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[Số HĐ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[Mã KH] [char](10) NOT NULL,
	[Tên KH] [nvarchar](50) NOT NULL,
	[Địa chỉ] [nvarchar](100) NOT NULL,
	[SĐT KH] [char](12) NOT NULL,
	[CMTKH] [char](12) NOT NULL,
	[GPLX] [char](12) NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[Mã KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHCHOTHUE]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHCHOTHUE](
	[STT] [int] NOT NULL,
	[Mã KH] [char](10) NOT NULL,
	[Mã loại] [char](10) NOT NULL,
	[Ngày đăng ký] [datetime] NOT NULL,
	[Ngày thuê] [datetime] NOT NULL,
	[Số ngày thuê] [int] NOT NULL,
 CONSTRAINT [PK_LICHCHOTHUE] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHTHUE]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHTHUE](
	[Số xe] [char](10) NOT NULL,
	[Mã KH] [char](10) NOT NULL,
	[Ngày giao] [datetime] NOT NULL,
	[Ngày trả] [datetime] NOT NULL,
	[Ngày giao thực tế] [datetime] NOT NULL,
	[Gia hạn] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIXE]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIXE](
	[Mã loại] [char](10) NOT NULL,
	[Tên loại] [nvarchar](50) NOT NULL,
	[Số lượng] [int] NOT NULL,
	[Mô tả] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LOAIXE] PRIMARY KEY CLUSTERED 
(
	[Mã loại] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[Mã NV] [char](10) NOT NULL,
	[Tên NV] [nvarchar](50) NOT NULL,
	[Vai trò] [nvarchar](100) NOT NULL,
	[CMTNV] [char](12) NOT NULL,
	[SĐT NV] [char](12) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[Mã NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCO]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCO](
	[Số BBSC] [char](10) NOT NULL,
	[Số xe] [char](10) NOT NULL,
	[Mã KH] [char](10) NOT NULL,
	[Tên SC] [nvarchar](50) NOT NULL,
	[Ngày BBSC] [datetime] NOT NULL,
	[Nội dung SC] [nvarchar](100) NOT NULL,
	[Tiền phạt] [char](10) NOT NULL,
	[Mã NV] [char](10) NOT NULL,
 CONSTRAINT [PK_SUCO] PRIMARY KEY CLUSTERED 
(
	[Số BBSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHTOAN]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHTOAN](
	[Số HĐTT] [char](10) NOT NULL,
	[Số HĐ] [char](10) NOT NULL,
	[Mã NV] [char](10) NOT NULL,
	[Ngày thanh toán] [datetime] NOT NULL,
	[Lý do] [nvarchar](50) NOT NULL,
	[Hồ sơ kèm] [nvarchar](50) NOT NULL,
	[Tiền TT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_THANHTOAN] PRIMARY KEY CLUSTERED 
(
	[Số HĐTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XE]    Script Date: 12/01/2021 2:43:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE](
	[Số xe] [char](10) NOT NULL,
	[Mã loại] [char](10) NOT NULL,
	[Tên xe] [nvarchar](50) NOT NULL,
	[Phí xăng] [char](10) NOT NULL,
	[Phí quá km] [char](10) NOT NULL,
	[Đơn giá] [char](10) NOT NULL,
	[Mô tả tình trạng] [nvarchar](100) NOT NULL,
	[Trạng thái] [int] NOT NULL,
 CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[Số xe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAIXE] ([Mã loại], [Tên loại], [Số lượng], [Mô tả]) VALUES (N'T001      ', N'Toyota', 2, N'Mới ')
INSERT [dbo].[LOAIXE] ([Mã loại], [Tên loại], [Số lượng], [Mô tả]) VALUES (N'T002      ', N'Huyndai', 3, N'Mới ')
INSERT [dbo].[LOAIXE] ([Mã loại], [Tên loại], [Số lượng], [Mô tả]) VALUES (N'T003      ', N'Mazda', 2, N'Mới ')
GO
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên NV], [Vai trò], [CMTNV], [SĐT NV]) VALUES (N'N001      ', N'Phan Nguyễn Trọng Đức', N'Giám đốc', N'197454194   ', N'0942663145  ')
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên NV], [Vai trò], [CMTNV], [SĐT NV]) VALUES (N'N002      ', N'Đinh Trọng Khanh', N'Kế toán', N'197458745   ', N'0914569845  ')
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên NV], [Vai trò], [CMTNV], [SĐT NV]) VALUES (N'N003      ', N'Nguyễn Hoàng Long', N'Sửa chữa', N'197648945   ', N'0948762456  ')
GO
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'51C1-74943', N'T001      ', N'Toyota Vios ', N'17000     ', N'20000     ', N'500000    ', N'Còn mới', 1)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'53C3-52834', N'T002      ', N'Hyundai Elantra 2020', N'17000     ', N'20000     ', N'500000    ', N'Còn mới', 1)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'59C2-34985', N'T002      ', N'Hyundai Accent 2021', N'17000     ', N'20000     ', N'500000    ', N'Còn mới', 0)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'59G1-46382', N'T001      ', N'Toyota Fortuner', N'18000     ', N'25000     ', N'600000    ', N'Còn mới', 0)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'59S1-92347', N'T003      ', N'Mazda 6', N'20000     ', N'25000     ', N'700000    ', N'Còn mới', 1)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'59T1-38521', N'T003      ', N'Mazda CX5', N'21000     ', N'25000     ', N'800000    ', N'Còn mới', 1)
INSERT [dbo].[XE] ([Số xe], [Mã loại], [Tên xe], [Phí xăng], [Phí quá km], [Đơn giá], [Mô tả tình trạng], [Trạng thái]) VALUES (N'59X3-23462', N'T002      ', N'Hyundai Santafe 2020', N'20000     ', N'25000     ', N'700000    ', N'Còn mới', 1)
GO
ALTER TABLE [dbo].[BIENBANGN]  WITH CHECK ADD  CONSTRAINT [FK_BIENBANGN_KHACHHANG] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[KHACHHANG] ([Mã KH])
GO
ALTER TABLE [dbo].[BIENBANGN] CHECK CONSTRAINT [FK_BIENBANGN_KHACHHANG]
GO
ALTER TABLE [dbo].[BIENBANGN]  WITH CHECK ADD  CONSTRAINT [FK_BIENBANGN_NHANVIEN] FOREIGN KEY([Mã NV])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[BIENBANGN] CHECK CONSTRAINT [FK_BIENBANGN_NHANVIEN]
GO
ALTER TABLE [dbo].[BIENBANGN]  WITH CHECK ADD  CONSTRAINT [FK_BIENBANGN_XE] FOREIGN KEY([Số xe])
REFERENCES [dbo].[XE] ([Số xe])
GO
ALTER TABLE [dbo].[BIENBANGN] CHECK CONSTRAINT [FK_BIENBANGN_XE]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_KHACHHANG] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[KHACHHANG] ([Mã KH])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_KHACHHANG]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_NHANVIEN] FOREIGN KEY([Mã NV])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_NHANVIEN]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_XE] FOREIGN KEY([Số xe])
REFERENCES [dbo].[XE] ([Số xe])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_XE]
GO
ALTER TABLE [dbo].[LICHCHOTHUE]  WITH CHECK ADD  CONSTRAINT [FK_LICHCHOTHUE_KHACHHANG] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[KHACHHANG] ([Mã KH])
GO
ALTER TABLE [dbo].[LICHCHOTHUE] CHECK CONSTRAINT [FK_LICHCHOTHUE_KHACHHANG]
GO
ALTER TABLE [dbo].[LICHCHOTHUE]  WITH CHECK ADD  CONSTRAINT [FK_LICHCHOTHUE_LOAIXE] FOREIGN KEY([Mã loại])
REFERENCES [dbo].[LOAIXE] ([Mã loại])
GO
ALTER TABLE [dbo].[LICHCHOTHUE] CHECK CONSTRAINT [FK_LICHCHOTHUE_LOAIXE]
GO
ALTER TABLE [dbo].[LICHTHUE]  WITH CHECK ADD  CONSTRAINT [FK_LICHTHUE_KHACHHANG] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[KHACHHANG] ([Mã KH])
GO
ALTER TABLE [dbo].[LICHTHUE] CHECK CONSTRAINT [FK_LICHTHUE_KHACHHANG]
GO
ALTER TABLE [dbo].[LICHTHUE]  WITH CHECK ADD  CONSTRAINT [FK_LICHTHUE_XE] FOREIGN KEY([Số xe])
REFERENCES [dbo].[XE] ([Số xe])
GO
ALTER TABLE [dbo].[LICHTHUE] CHECK CONSTRAINT [FK_LICHTHUE_XE]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [FK_SUCO_KHACHHANG] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[KHACHHANG] ([Mã KH])
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [FK_SUCO_KHACHHANG]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [FK_SUCO_NHANVIEN] FOREIGN KEY([Mã NV])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [FK_SUCO_NHANVIEN]
GO
ALTER TABLE [dbo].[SUCO]  WITH CHECK ADD  CONSTRAINT [FK_SUCO_XE] FOREIGN KEY([Số xe])
REFERENCES [dbo].[XE] ([Số xe])
GO
ALTER TABLE [dbo].[SUCO] CHECK CONSTRAINT [FK_SUCO_XE]
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_THANHTOAN_HOPDONG] FOREIGN KEY([Số HĐ])
REFERENCES [dbo].[HOPDONG] ([Số HĐ])
GO
ALTER TABLE [dbo].[THANHTOAN] CHECK CONSTRAINT [FK_THANHTOAN_HOPDONG]
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_THANHTOAN_NHANVIEN] FOREIGN KEY([Mã NV])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[THANHTOAN] CHECK CONSTRAINT [FK_THANHTOAN_NHANVIEN]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_XE_LOAIXE] FOREIGN KEY([Mã loại])
REFERENCES [dbo].[LOAIXE] ([Mã loại])
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_XE_LOAIXE]
GO
