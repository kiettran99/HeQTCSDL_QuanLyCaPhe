use QuanLyCaPhe
go
--1. Tạo Chi Tiết Hóa Đơn
drop procedure if exists Create_ChiTietHoaDon
go

create procedure Create_ChiTietHoaDon @idHoaDon int, @idThucAn int, @soLuong int
as
begin
	insert into ChiTietHoaDon values(@idHoaDon, @idThucAn, @soLuong)
end
go

--2. Đọc Chi Tiết Hóa Đơn
drop procedure if exists Read_ChiTietHoaDon
go

create procedure Read_ChiTietHoaDon
as
begin
	select * from ChiTietHoaDon
end
go

drop procedure if exists Read_ChiTietHoaDon_ID
go

create procedure Read_ChiTietHoaDon_ID @idHoaDon int, @idThucAn int
as
begin
	select * 
	from ChiTietHoaDon
	where IDHoaDon = @idHoaDon and IDThucAn = @idThucAn
end
go

--3. Sửa Chi Tiết Hóa Đơn
drop procedure if exists Update_ChiTietHoaDon
go

create procedure Update_ChiTietHoaDon @idHoaDon int, @idThucAn int, @soLuong int
as
begin
	update ChiTietHoaDon
	set SoLuong = @soLuong
	where IDHoaDon = @idHoaDon and IDThucAn = @idThucAn
end
go

--4. Xóa Chi Tiết Hóa Đơn
drop procedure if exists Delete_ChiTietHoaDon
go

create procedure Delete_ChiTietHoaDon @idHoaDon int, @idThucAn int
as
begin
	delete from ChiTietHoaDon 
	where IDHoaDon = @idHoaDon and IDThucAn = @idThucAn
end
go