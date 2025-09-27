IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BookStoreDB')
BEGIN
    CREATE DATABASE BookStoreDB;
END
GO
USE BookStoreDB;
GO

-- Tạo bảng nếu chưa có
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DonHang' AND xtype='U')
BEGIN
    CREATE TABLE DonHang (
        MaDonHang INT PRIMARY KEY IDENTITY(1,1),
        MaKhachHang NVARCHAR(20) NOT NULL,
        DiaChi NVARCHAR(255) NOT NULL,
        NgayDatHang DATETIME NOT NULL,
        TongTien DECIMAL(18,2) NOT NULL,
        TrangThai NVARCHAR(50) NOT NULL
    );
END
GO

-- Thêm dữ liệu mẫu nếu chưa tồn tại
IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH123' AND NgayDatHang='2024-01-15')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH123', N'123 Nguyễn Văn Linh, Quận 7, TP.HCM', '2024-01-15', 1250000, N'Đã Giao');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH456' AND NgayDatHang='2024-01-16')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH456', N'45 Lê Lợi, Quận 1, TP.HCM', '2024-01-16', 850000, N'Đang Vận Chuyển');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH789' AND NgayDatHang='2024-01-17')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH789', N'78 Trần Hưng Đạo, Quận 5, TP.HCM', '2024-01-17', 2100000, N'Đang Xử lí');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH101' AND NgayDatHang='2024-01-15')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH101', N'101 Võ Văn Kiệt, Quận 1, TP.HCM', '2024-01-15', 550000, N'Đã Giao');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH112' AND NgayDatHang='2024-01-18')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH112', N'112 Nguyễn Huệ, Quận 1, TP.HCM', '2024-01-18', 1750000, N'Đang Vận Chuyển');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH131' AND NgayDatHang='2024-01-16')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH131', N'131 Lý Tự Trọng, Quận 1, TP.HCM', '2024-01-16', 920000, N'Đã Giao');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH415' AND NgayDatHang='2024-01-19')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH415', N'415 Cách Mạng Tháng 8, Quận 3, TP.HCM', '2024-01-19', 3100000, N'Đang Xử lí');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH526' AND NgayDatHang='2024-01-17')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH526', N'526 Nguyễn Trãi, Quận 5, TP.HCM', '2024-01-17', 680000, N'Đang Vận Chuyển');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH75' AND NgayDatHang='2025-09-09')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH75', N'125 Trần Hưng Đạo, Đà Nẵng', '2025-09-09', 625000, N'Đang Xử lí');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH16' AND NgayDatHang='2025-09-08')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH16', N'07 Hoàng Văn Thụ, Hải Phòng', '2025-09-08', 215000, N'Đang Vận Chuyển');
END

IF NOT EXISTS (SELECT 1 FROM DonHang WHERE MaKhachHang='KH05' AND NgayDatHang='2025-09-06')
BEGIN
    INSERT INTO DonHang (MaKhachHang, DiaChi, NgayDatHang, TongTien, TrangThai)
    VALUES ('KH05', N'75 Hoàng Hoa Thám, Hà Nội', '2025-09-06', 124000, N'Đã Giao');
END
GO
