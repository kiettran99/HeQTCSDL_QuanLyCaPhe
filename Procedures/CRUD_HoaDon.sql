use QuanLyCaPhe
go
--1. Tạo Hóa Đơn
drop procedure if exists Create_HoaDon
go

create procedure Create_HoaDon @IDHoaDon int,
	@NgayTaoHoaDon datetime,
	@NgayKetThucHoaDon datetime,
	@IDBanAn int,
	@TongTien float,
	@GiamGia int,
	@TinhTrang bit
as
begin
	insert into HoaDon values(@idHoaDon, @NgayTaoHoaDon, @IDBanAn, @TongTien, @GiamGia, @TinhTrang)
end
go

--2. Đọc Hóa Đơn
drop procedure if exists Read_HoaDon
go

create procedure Read_HoaDon
as
begin
	select * from HoaDon
end
go

drop procedure if exists Read_HoaDon_ID
go

create procedure Read_HoaDon_ID @idHoaDon int
as
begin
	select * 
	from HoaDon
	where IDHoaDon = @idHoaDon
end
go

--3. Sửa Hóa Đơn
drop procedure if exists Update_HoaDon
go

create procedure Update_HoaDon @idHoaDon int, @NgayTaoHoaDon datetime,
	@NgayKetThucHoaDon datetime,
	@IDBanAn int,
	@TongTien float,
	@GiamGia int,
	@TinhTrang bit
as
begin
	update HoaDon
	set NgayTaoHoaDon = @NgayTaoHoaDon, NgayKetThucHoaDon = @NgayKetThucHoaDon,
	IDBanAn = @IDBanAn, TongTien = @TongTien, GiamGia = @GiamGia, TinhTrang = @TinhTrang
	where IDHoaDon = @idHoaDon
end
go

--4. Xóa Hóa Đơn
drop procedure if exists Delete_HoaDon
go

create procedure Delete_HoaDon @idHoaDon int
as
begin
	delete from HoaDon 
	where IDHoaDon = @idHoaDon
end
go