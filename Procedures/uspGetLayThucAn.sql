﻿--Lấy Thức Ăn 
USE QuanLyCaPhe
GO
IF OBJECT_ID('uspGetLayThucAn') IS NOT NULL
DROP PROC uspGetLayThucAn
GO
CREATE PROC uspGetLayThucAn
	@TenThucAn nvarchar(50)
AS
BEGIN
	select * from ThucAn;
END
--GO
EXEC uspGetLayThucAn 'Trái Cây Tô';