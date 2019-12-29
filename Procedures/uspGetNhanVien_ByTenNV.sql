USE QuanLyCaPhe
GO
IF OBJECT_ID('uspGetNhanVien_ByTenNV') IS NOT NULL
DROP PROC uspGetNhanVien_ByTenNV
GO
CREATE PROC uspGetNhanVien_ByTenNV
	@TenNV nvarchar(50)
AS
BEGIN
	SELECT * 
	FROM NhanVien
	WHERE @TenNV=TenNV
END
--TEST
EXEC uspGetNhanVien_ByTenNV 'Nguyen';