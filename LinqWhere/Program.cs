using Database;

var empDB = new Employee().GetEmployees();



//Query Syntax
var employee = (from emp in empDB
                where emp.EmpId == 2
                select emp.EmpName).ToList();

// Console.WriteLine(employee[0]);





//Method Syntax
var methEmployee = empDB.Where(emp => emp.EmpId == 2).Select(emp => emp.EmpName).ToList();
Console.WriteLine(methEmployee[0]);





//Query Syntax
/* var QuerySyntax = (from employee in Employee.GetEmployees()
                  where employee.Salary >= 50000 && employee.Technology != null
                  select new {
                      EmployeeName = employee.Name,
                      Gender = employee.Gender,
                      MonthlySalary = employee.Salary / 12
                  }).ToList(); */

//Method Syntax
/* var MethodSyntax = Employee.GetEmployees()
                   .Where(emp => emp.Salary >= 50000 && emp.Technology != null)
                   .Select(emp => new {
                       EmployeeName = emp.Name,
                       Gender = emp.Gender,
                       MonthlySalary = emp.Salary / 12
                   })
                   .ToList(); */