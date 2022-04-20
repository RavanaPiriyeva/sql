create database tv
use tv
create table genre(
id int primary key identity ,
name nvarchar(20),
)


create table tvproggram(
id int primary key identity ,
name nvarchar(20),
duarition int,
chanelname nvarchar(10),
)

create table genreprogram (
id int primary key identity , 
programid int foreign key references tvproggram(id),
genreid int foreign key references genre(id),
)

create table anoncer(
id int primary key identity ,
name nvarchar(20),
surname nvarchar(20),
)

create table programanoncer(
id int primary key identity , 
programid int foreign key references tvproggram(id),
anoncerid int foreign key references anoncer(id),
)

create table deleteprogramanoncers(
 id int primary key identity , 
 pronanon int,
programid int ,
anoncerid int ,
)


create TRIGGER usersdeletesss
ON programanoncer
AFTER DELETE 
AS
 BEGIN
 INSERT INTO deleteprogramanoncers(pronanon,programid,anoncerid) 
 SELECT id,programid,anoncerid FROM deleted
 END
 

 select * from programanoncer
 select * from deleteprogramanoncers

 DELETE FROM programanoncer WHERE id=6

 

 select programanoncer.*,genre.name,anoncer.name+' '+anoncer.surname as 'fullname' , (select count(id) from deleteprogramanoncers)  as 'count' from programanoncer
 join tvproggram on tvproggram.id=programanoncer.programid
 join genreprogram  on tvproggram.id=genreprogram.programid
 join genre on genreprogram.genreid=genre.id
 join anoncer on programanoncer.anoncerid=anoncer.id
where genre.name like '%a%'





 