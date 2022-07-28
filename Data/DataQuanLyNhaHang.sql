CREATE DATABASE QuanLyNhaHang
GO

USE QuanLyNhaHang
GO

-- Food
-- TableFood
-- FoodCategory
-- Account
-- Bill
-- BillInfo

-- Create TableFood
CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
--Creata Account
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Khang',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)

--Create FoodCategory
CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)

--Create Food
CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)

--Create Bill
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETUTCDATE(),
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	NameCustomer nvarchar(255),
	Discount int
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)

--Create BillInfo
CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)

--Them tai khoan
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'Admin' , -- UserName - nvarchar(100)
          N'Khang' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'Staff' , -- UserName - nvarchar(100)
          N'Hoang' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )


CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END


CREATE PROC USP_Login
@userName nvarchar(100),
@passWord varchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName and PassWord = @passWord
END

EXEC dbo.USP_GetAccountByUserName @userName = N' ' OR 1=1 -- -- nvarchar(100)
EXEC dbo.USP_Login @userName = 'Admin' ,@passWord = '1'

--Chen du lieu ban an vao Data
DECLARE @i INT = 11

WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

--delete
DECLARE @i INT = 1

WHILE @i <= 10
BEGIN
	Delete from TableFood 
	SET @i = @i + 1
END

--reset id
DBCC CHECKIDENT ('[TableFood]', RESEED, 0);


Alter PROC USP_GetTableList
AS Select * from TableFood
Go
UPDATE dbo.TableFood SET STATUS = N'Có người' where id = 9
EXEC USP_GetTableList
Go

--Thêm category
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Hải sản'  -- name - nvarchar(100)
          )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nướng' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Hấp' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Gỏi' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước' )

-- thêm món ăn
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Mực một nắng nước sa tế', -- name - nvarchar(100)
          1, -- idCategory - int
          120000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cá thu sốt', 1, 50000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Dú dê nướng sữa', 2, 60000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Thịt bò Hấp', 3, 75000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Gỏi sứa', 4, 999999)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'7Up', 5, 15000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cafe', 5, 12000)

-- thêm bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETUTCDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          0  -- status - int
        )      
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETUTCDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETUTCDATE() , -- DateCheckIn - date
          GETUTCDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )

-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          6, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )    

Alter PROC USP_InsertBill
@idTable INT
as 
begin
	insert Bill
	(
		DateCheckIn,
		DateCheckOut,
		idTable,
		status,
		discount
	)
	values(GetUTCdate(), --date check in
			Null, --date check out,
			@idTable, --idTable
			0, -- status
			0
			)
end

--DROP PROCEDURE [USP_InsertBill];

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood Int, @count INT
AS
BEGIN
	DECLARE @isExitBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExitBillInfo = id, @foodCount = b.count
	FROM BillInfo as b
	WHERE idBill = @idBill and idFood = @idFood

	IF(@isExitBillInfo > 0)
		BEGIN
			DECLARE @newCount INT = @foodCount + @count
			IF(@newCount >= 0)
				UPDATE BillInfo SET count = @foodCount + @count where idFood = @idFood
			ElSE
				DELETE BillInfo WHERE idBill = @idBill and idFood = @idFood
		END
	ELSE	
		BEGIN
		insert BillInfo
			(idBill, idFood, count)
		values (@idBill, @idFood,@count)
		END
End

--trigger them mon 
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

--trigger chuyen ban
ALTER TRIGGER UTG_UpdateTable
ON TableFood FOR UPDATE
AS 
BEGIN
	DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)

	SELECT @idTable = id, @status = inserted.status FROM inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM dbo.Bill WHERE	idTable = @idTable AND	status = 0

	DECLARE @countBillInfo Int
	select @countBillInfo = COUNT(*) from BillInfo where idBill = @idBill

	IF(@countBillInfo > 0 and @status <> N'Có người')
		update TableFood SET STATUS = N'Có người' Where id = @idTable
	ELSE IF(@countBillInfo <= 0 and @status <> N'Trống')
		update TableFood SET STATUS = N'Trống' Where id = @idTable 
END


CREATE Trigger UTG_UpdateBill
on Bill for Update
as
begin 
	declare @idBill int

	select @idBill = id from Inserted

	declare @idTable int

	select @idTable = idTable from bill where id = @idBill

	declare @count int = 0

	select @count = Count(*) from Bill where idTable = @idTable and status = 0
	
	if(@count = 0)
		Update TableFood set status = N'Trống' where id = @idTable
end 

--Chuyển bàn
ALTER PROC USP_SwitchTable
@idTable1 INT,@idTable2 INT
AS BEGIN
	DECLARE @idFirstBill int
	DECLARE @idSecondBill int

	SELECT @idSecondBill = id FROM Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM Bill WHERE idTable = @idTable1 AND status = 0

	if(@idFirstBill is null)
	Begin
		insert Bill (
			DateCheckIn,
			DateCheckOut,
			idTable,
			status
		)
		values (
			GETDATE(),
			null,
			@idTable1,
			0
		)
		select @idFirstBill = max(id) from Bill WHERE idTable = @idTable1 AND status = 0
	end

	if(@idSecondBill is null)
	Begin
		insert Bill (
			DateCheckIn,
			DateCheckOut,
			idTable,
			status
		)
		values (
			GETDATE(),
			null,
			@idTable2,
			0
		)
		select @idSecondBill = max(id) from Bill WHERE idTable = @idTable2 AND status = 0
	end

	SELECT id INTO IDBillInfoTable FROM BillInfo WHERE idBill = @idSecondBill
	UPDATE BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE BillInfo SET idBill = @idFirstBill WHERE id in (select * from IDBillInfoTable)

	DROP Table IDBillInfoTable
end
GO

--tao prc thong ke ban, gia hoa don , check out, check in , discount
alter PROC USP_GetListBillByDate
@dateCheckIn DATETIME, @dateCheckOut DATETIME
AS
BEGIN
	SELECT t.name as [Tên Bàn], b.DateCheckIn as [Vào], b.DateCheckOut [Ra], b.Discount [Giảm Giá], b.totalPrice [Tổng Tiền] FROM dbo.TableFood t, dbo.Bill b
	WHERE b.DateCheckIn >= @dateCheckIn AND b.DateCheckOut <= @dateCheckOut AND b.status = 1 AND t.id = b.idTable
END

select * from account

--tao pro update tai khoan

Alter proc USP_UpdateAccount
@userName varchar(100) , @displayName nvarchar(100), @password varchar(30), @newPassword varchar(30)
as
begin
	declare @count  int = 0

	select @count = count(*) from Account where UserName = @userName  and PassWord = @password

	if(@count = 1)
	begin
		if(@newPassword is NULL or @newPassword = '')
		begin
			update Account set DisplayName = @displayName where UserName = @userName
		end
		else
			update Account set DisplayName = @displayName , PassWord = @newPassword where UserName = @userName
	end
end
