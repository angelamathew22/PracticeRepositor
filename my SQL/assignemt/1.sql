create database assignmentDB
create table Customers(
 Customerid char(5) not null,
 CompanyName varchar(40) not null,
City char(15) null,
Phone char(24) null,
Fax char(24) null)

--Order Table
customerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddres varchar(60) null,
Quantity integer null)