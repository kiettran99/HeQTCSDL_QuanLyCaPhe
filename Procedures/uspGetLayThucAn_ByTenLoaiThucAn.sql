--Lấy Thức Ăn Theo Loại 
USE QuanLyCaPhe
GO
IF OBJECT_ID('uspGetLayThucAn') IS NOT NULL
DROP PROC uspGetLayThucAn
GO
CREATE PROC uspGetLayThucAn
	@TenLoaiThucAn nvarchar(50)
AS
BEGIN
	SELECT DISTINCT TenThucAn
	FROM dbo.ThucAn join dbo.LoaiThucAn on ThucAn.IDLoaiThucAn = LoaiThucAn.IDLoaiThucAn
	where TenLoaiThucAn=@TenLoaiThucAn
END
--GO
EXEC uspGetLayThucAn 'Trái Cây Tô';