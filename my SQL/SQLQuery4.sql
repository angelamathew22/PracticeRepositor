select * from Dept
select * from Employee
insert into Dept(Dept_Code,Dept_Name) values('D003', 'Product'),('D004', 'Sales')
insert into Employee(Id,Name,joindate,Salary,Dept_Code) values(1,'jo',getdate(),50000,'D002'),(2,'john',getdate(),55000,'D001'),
(3,'jobi',getdate(),40000,'D001'),(4,'joli',getdate(),60000,'D003'),(10,'mohan',getdate(),30000,'D001'),(16,'hari',getdate(),70000,'D002'),(19,'ashin',getdate(),45000,'D003'),(13,'joshy',getdate(),57000,'D002'),(12,'harsha',getdate(),59000,null),(21,'Angel',getdate(),65000,null)