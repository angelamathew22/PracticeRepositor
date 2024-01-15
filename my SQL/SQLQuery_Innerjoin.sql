select * from Dept
select * from Empolyee
select e.id,e.joinDate,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code
select e.id,e.Name,e.salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code order by d.Dept_Name
select e.id,salary,d.Dept_Name from Employee e join Dept d on e.Dept_Code=d.Dept_Code where d.Dept_Name='Admin' order by d.Dept Name
select COUNT(e.id) from Empolyee e join Dept d on e.Dept_Code=d.Dept_Code where d.Dept_Name='Admin'