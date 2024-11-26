USE [QLTV]
GO
/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 27/11/2024 2:33:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHU](
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MAPHIEU] [int] NOT NULL,
	[NGAYTHANHTOAN] [datetime] NULL,
	[THANHTIEN] [decimal](10, 1) NULL,
 CONSTRAINT [PK_DOANHTHU] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 27/11/2024 2:33:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MADOCGIA] [nvarchar](30) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[DIENTHOAI] [nvarchar](20) NULL,
	[CMND] [nvarchar](20) NULL,
	[NGAYLAMTHE] [date] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MADOCGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 27/11/2024 2:33:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MAPHIEU] [int] IDENTITY(1,1) NOT NULL,
	[MADOCGIA] [nvarchar](30) NOT NULL,
	[MASACH] [nvarchar](30) NULL,
	[TENSACH] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[NGAYMUON] [date] NULL,
	[NGAYTRA] [date] NULL,
	[GIAMUON] [decimal](10, 1) NULL,
	[TRANGTHAI] [nchar](20) NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 27/11/2024 2:33:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [nvarchar](30) NOT NULL,
	[TENSACH] [nvarchar](30) NULL,
	[THELOAI] [nvarchar](30) NULL,
	[GIASACH] [int] NULL,
	[NHAXUATBAN] [nvarchar](50) NULL,
	[NGAYXUATBAN] [date] NULL,
	[TENTACGIA] [nvarchar](30) NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 27/11/2024 2:33:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TAIKHOAN] [nvarchar](50) NOT NULL,
	[MATKHAU] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DOANHTHU] ON 

INSERT [dbo].[DOANHTHU] ([MAHD], [MAPHIEU], [NGAYTHANHTOAN], [THANHTIEN]) VALUES (20, 1, CAST(N'2024-11-29T00:00:00.000' AS DateTime), CAST(40000.0 AS Decimal(10, 1)))
INSERT [dbo].[DOANHTHU] ([MAHD], [MAPHIEU], [NGAYTHANHTOAN], [THANHTIEN]) VALUES (21, 2, CAST(N'2024-11-30T00:00:00.000' AS DateTime), CAST(120000.0 AS Decimal(10, 1)))
INSERT [dbo].[DOANHTHU] ([MAHD], [MAPHIEU], [NGAYTHANHTOAN], [THANHTIEN]) VALUES (22, 3, CAST(N'2024-12-04T00:00:00.000' AS DateTime), CAST(120000.0 AS Decimal(10, 1)))
INSERT [dbo].[DOANHTHU] ([MAHD], [MAPHIEU], [NGAYTHANHTOAN], [THANHTIEN]) VALUES (23, 4, CAST(N'2025-01-04T00:00:00.000' AS DateTime), CAST(600000.0 AS Decimal(10, 1)))
SET IDENTITY_INSERT [dbo].[DOANHTHU] OFF
GO
INSERT [dbo].[DOCGIA] ([MADOCGIA], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [DIENTHOAI], [CMND], [NGAYLAMTHE]) VALUES (N'DG1', N'Phan Hải Quân', CAST(N'2003-12-30' AS Date), N'Nữ', N'Thái Nguyên', N'09302232', N'0023123113', CAST(N'2020-02-02' AS Date))
INSERT [dbo].[DOCGIA] ([MADOCGIA], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [DIENTHOAI], [CMND], [NGAYLAMTHE]) VALUES (N'DG2', N'Nguyễn Tân Hoàng Nam', CAST(N'2003-12-01' AS Date), N'Nữ', N'Hà Nội', N'09323221', N'02300223123', CAST(N'2020-02-01' AS Date))
INSERT [dbo].[DOCGIA] ([MADOCGIA], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [DIENTHOAI], [CMND], [NGAYLAMTHE]) VALUES (N'DG3', N'Nguyễn Xuân Trường', CAST(N'2003-12-20' AS Date), N'Nam', N'Hà Nội', N'09232313', N'092322322222', CAST(N'2003-02-10' AS Date))
INSERT [dbo].[DOCGIA] ([MADOCGIA], [HOTEN], [NGAYSINH], [GIOITINH], [DIACHI], [DIENTHOAI], [CMND], [NGAYLAMTHE]) VALUES (N'DG4', N'Nam Beo', CAST(N'2024-11-25' AS Date), N'nu', N'nd', N'023020202', N'00000000000', CAST(N'2024-11-25' AS Date))
GO
SET IDENTITY_INSERT [dbo].[PHIEUMUON] ON 

INSERT [dbo].[PHIEUMUON] ([MAPHIEU], [MADOCGIA], [MASACH], [TENSACH], [SOLUONG], [NGAYMUON], [NGAYTRA], [GIAMUON], [TRANGTHAI]) VALUES (1, N'DG1', N'1', N'Đắc nhân tâm', 1, CAST(N'2024-11-27' AS Date), CAST(N'2024-11-29' AS Date), CAST(20000.0 AS Decimal(10, 1)), N'Đã Trả              ')
INSERT [dbo].[PHIEUMUON] ([MAPHIEU], [MADOCGIA], [MASACH], [TENSACH], [SOLUONG], [NGAYMUON], [NGAYTRA], [GIAMUON], [TRANGTHAI]) VALUES (2, N'DG2', N'2', N'Hạt giống tâm hồn', 2, CAST(N'2024-11-27' AS Date), CAST(N'2024-11-30' AS Date), CAST(40000.0 AS Decimal(10, 1)), N'Đã Trả              ')
INSERT [dbo].[PHIEUMUON] ([MAPHIEU], [MADOCGIA], [MASACH], [TENSACH], [SOLUONG], [NGAYMUON], [NGAYTRA], [GIAMUON], [TRANGTHAI]) VALUES (3, N'DG3', N'1', N'Đăc Nhân Tâm', 2, CAST(N'2024-12-01' AS Date), CAST(N'2024-12-04' AS Date), CAST(40000.0 AS Decimal(10, 1)), N'Đã Trả              ')
INSERT [dbo].[PHIEUMUON] ([MAPHIEU], [MADOCGIA], [MASACH], [TENSACH], [SOLUONG], [NGAYMUON], [NGAYTRA], [GIAMUON], [TRANGTHAI]) VALUES (4, N'DG3', N'1', N'Hạt Giống tâm hồn', 2, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-04' AS Date), CAST(200000.0 AS Decimal(10, 1)), N'Đã Trả              ')
SET IDENTITY_INSERT [dbo].[PHIEUMUON] OFF
GO
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [THELOAI], [GIASACH], [NHAXUATBAN], [NGAYXUATBAN], [TENTACGIA], [SOLUONG]) VALUES (N'1', N'Đắc Nhân Tâm', N'Đời sống', 100000, N'Kim đồng', CAST(N'2023-01-01' AS Date), N'Phan Hải Quân', 7)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [THELOAI], [GIASACH], [NHAXUATBAN], [NGAYXUATBAN], [TENTACGIA], [SOLUONG]) VALUES (N'2', N'Hạt giống tâm hồn', N'Đời sống', 99000, N'Đời sống', CAST(N'2023-01-01' AS Date), N'Nguyễn Xuân Trường', 12)
GO
INSERT [dbo].[TAIKHOAN] ([TAIKHOAN], [MATKHAU], [EMAIL]) VALUES (N'luong', N'123', N'luong@gmail.com')
GO
ALTER TABLE [dbo].[DOANHTHU]  WITH CHECK ADD  CONSTRAINT [FK_DOANHTHU_PHIEUMUON] FOREIGN KEY([MAPHIEU])
REFERENCES [dbo].[PHIEUMUON] ([MAPHIEU])
GO
ALTER TABLE [dbo].[DOANHTHU] CHECK CONSTRAINT [FK_DOANHTHU_PHIEUMUON]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_SACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_SACH]
GO
