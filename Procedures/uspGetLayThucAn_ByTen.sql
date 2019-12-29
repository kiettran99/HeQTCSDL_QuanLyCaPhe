--Lấy Thức Ăn 
USE QuanLyCaPhe
GO
IF OBJECT_ID('uspGetLayThucAn') IS NOT NULL
DROP PROC uspGetLayThucAn
GO
CREATE PROC uspGetLayThucAn
	@TenThucAn nvarchar(50)
AS
BEGIN
	SELECT DISTINCT TenThucAn
	FROM dbo.ThucAn
	WHERE TenThucAn=@TenThucAn
END
--GO
EXEC uspGetLayThucAn 'Trái Cây Tô';