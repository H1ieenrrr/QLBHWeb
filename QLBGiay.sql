


create database QLBGiay
go
use QLBGiay
go
--san pham--
create table Products
(
Product_Id int IDENTITY(1,1) primary key,
Product_Name nvarchar(200),
Product_Date datetime,
Product_Image nvarchar(200),
Product_Amount int,
Catgory_Id int,
Product_Price money
)
go
--thể loại
create table Catgorys
(
Catgory_Id int IDENTITY(1,1) primary key,
Product_Id int,
Product_Name nvarchar(200),
foreign key (Product_Id)
references Products(Product_Id)
)
go
--user
create table Users
(
Users_Id int IDENTITY(1,1) primary key,
Users_Name nvarchar(50),
Users_Email varchar(50),
Users_Password varchar(50),
Users_Phone varchar(50)
)
go
--khach hang--
create table Customers
(
Customer_Id int IDENTITY(1,1) primary key,
Customer_Name nvarchar(50),
Customer_Email varchar(50),
Customer_Address nvarchar(200),
Customer_Phone varchar(50)
)

--gio hàng
create table Cart
(
Cart_Id int IDENTITY(1,1) primary key,
Users_Id int,
Customer_Id int,
foreign key (Users_Id)
references Users(Users_Id),
foreign key (Customer_Id)
references Customers(Customer_Id)
)

go
--chi tiet gio hang--
create table Cart_Detail(
CartDetail_Id  int IDENTITY(1,1) primary key,
Cart_Id int,
Customer_Id int,
Product_Id int,
Product_Name nvarchar(200),
Product_Amount int,
Product_Price int,
Total_Price int
foreign key (Cart_Id)
references Cart(Cart_Id),
foreign key (Product_Id)
references Products(Product_Id)
)
go
INSERT INTO Products VALUES 
('Giày Jordan 1 Low Pink','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Green','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Black','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low White','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Yellow','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Blue','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Orange','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Purple','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Red','2022-01-22','/images/','100','1','3000000'),
('Giày Jordan 1 Low Red','2022-01-22','/images/','100','1','3000000'),
('Giày Adidas UltraBoost 22','2022-01-22','/images/','100','1','3000000'),
('Giày Adidas UltraBoost 21','2022-01-22','/images/','100','1','3000000'),
('Giày Adidas UltraBoost 20 Lab','2022-01-22','/images/','100','1','3000000'),
('Giày Adidas UltraBoost 5.0','2022-01-22','/images/','100','1','3000000'),
('Giày Adidas AlphaBounce','2022-01-22','/images/','100','1','3000000');
go
INSERT INTO Catgorys Values
('1','Giày Nike'),
('11','Giày Adidas');
go
INSERT INTO Users Values
('Lê Tấn Hiển','trish20028@gmail.com','123','0862733026'),
('Nguyễn Tấn','123@gmail.com','123','0123456789'),
('Lê Tấn','312@gmail.com','123','0987654321');