--SP:  Thêm Một Loại Thức Ăn Mới Vào Table: Thức Ăn
USE QuanLyCaPhe
GO
IF OBJECT_ID('uspUpdateThucAn') IS NOT NULL
	DROP PROC uspUpdateThucAn
GO
CREATE PROCEDURE uspUpdateThucAn
		@IDHoaDon int,
		@IDThucAn 	int ,
		@TenThucAn 	nvarchar(50),
		@IDLoaiThucAn  int ,
		@Gia float ,
		@TenLoaiThucAn nvarchar(500),
		@SoLuong int
AS
	--Kiểm Soát Các Lỗi Đầu Vào
	IF @IDHoaDon is null 
	THROW 50001,'ID Thức Ăn  Không Được Phép NULL!',1;
	IF @IDThucAn is null 
	THROW 50001,'ID Thức Ăn  Không Được Phép NULL!',1;
	IF @IDLoaiThucAn is null 
	THROW 50001,'ID Thức Ăn  Không Được Phép NULL!',1;
	IF EXISTS (SELECT * FROM ThucAn WHERE IDThucAn=@IDThucAn)
	THROW 50001,'Ma Thức Ăn Này Đã Tồn Tại!',1;
	IF @TenThucAn is null OR @TenThucAn = ''
	THROW 50001,'HoVaTenNV Không Được Để Trống!',1;
		IF @TenLoaiThucAn is null OR @TenThucAn = ''
	THROW 50001,'HoVaTenNV Không Được Để Trống!',1;
	IF @Gia < 1
	THROW 50001,'Gia phải lớn hơn',1;
		IF @SoLuong <= 1
	THROW 50001,'Số Lượng phải lớn hơn',1;
	BEGIN TRANSACTION
	BEGIN TRY
		--Update HDLV
		UPDATE ChiTietHoaDon
			SET IDHoaDon = @IDHoaDon,
			SoLuong=@SoLuong
			WHERE IDHoaDon=@IDHoaDon
		UPDATE ThucAn
			SET IDThucAn=@IDThucAn,
			IDLoaiThucAn=@IDLoaiThucAn,
			Gia=@Gia
			WHERE IDThucAn=@IDThucAn
			UPDATE LoaiThucAn
			SET IDLoaiThucAn=@IDLoaiThucAn
				where IDLoaiThucAn=@IDLoaiThucAn
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	END CATCH		
			