create table Department
(
	Id int identity(1, 1),
	[Name] nvarchar(100),
	[Desc] nvarchar(200),
	Established datetime2
);

--alter table Department
--ALTER COLUMN Id varchar

ALTER TABLE Department
ADD PRIMARY KEY (Id);

insert into Departments
values ('OPD', 'Its OPD department', '2012/12/12')

select * from Departments

update Department set Name = 'Neuro' where Id=2

delete from Department where Id=4