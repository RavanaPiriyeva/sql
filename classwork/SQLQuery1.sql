create database shopp
use shopp
create table adress
(id int primary key identity,
 country nvarchar not null,
 city nvarchar,
 phone int,
)

create table cusstomer
(
id int primary key identity,
name nvarchar,
surname nvarchar,
)

create table customeradress(
id int primary key identity,
customerid int foreign key references cusstomer(id),
adressid int foreign key references adress(id),
)

create table orders (
id int primary key identity,
customerid int foreign key references cusstomer(id),
cretedate datetime2 ,
note nvarchar,
)

create table type (
id int primary key identity,
name nvarchar,
description nvarchar,

)

create table products (
id int primary key identity,
name nvarchar,
typeid int foreign key references type(id),
price money ,
)
create table orderproduct (
id int primary key identity,
orderid int foreign key references orders(id),
productid int foreign key references products(id),
)

create view vw_shopinfo
as
select adress.id, count(typeid) as 'type count',avg(price) as 'avg'  from adress
 join customeradress on customeradress.adressid=adress.id
  join cusstomer on  customeradress.customerid=cusstomer.id
  join orders on cusstomer.id=orders.customerid
  join orderproduct on orderproduct.orderid=orders.id
  join products on  orderproduct.productid=products.id
  join type on products.typeid=type.id
group by adress.id 

create view vw_shopinfo2
as
select vw_shopinfo.*,adress.country,adress.city,adress.phone from vw_shopinfo
join adress on adress.id=vw_shopinfo.id

CREATE PROCEDURE usp_filterInfo
@min int,
@max int
AS
SELECT * FROM vw_shopinfo2
WHERE vw_shopinfo2.avg between @min and @max



EXEC usp_filterInfo 60,100





select products.name , type.name ,adress.country ,adress.city from adress
 join customeradress on customeradress.adressid=adress.id
  join cusstomer on  customeradress.customerid=cusstomer.id
  join orders on cusstomer.id=orders.customerid
  join orderproduct on orderproduct.orderid=orders.id
  join products on  orderproduct.productid=products.id
  join type on products.typeid=type.id
where products.name like'%a%'




