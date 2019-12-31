-- Xóa Nhân Viên

USE QuanLyCaPhe
GO
IF OBJECT_ID('uspDeleteNhanVien') IS NOT NULL
	DROP PROC uspDeleteNhanVien
GO
CREATE PROCEDURE uspDeleteNhanVien
	@MaNV nvarchar(50)
AS
	--Kiểm Soát Lỗi
	
	DELETE FROM NhanVien WHERE MaNV = @MaNV
--Test
select *from NhanVien
EXEC uspDeleteNhanVien '1'

IF OBJECT_ID('uspDeleteTinhLuong') IS NOT NULL
	DROP PROC uspDeleteTinhLuong
GO
CREATE PROCEDURE uspDeleteTinhLuong
	@MaNV nvarchar(50)
AS
	--Kiểm Soát Lỗi
	
	DELETE FROM TinhLuong WHERE MaNV = @MaNV