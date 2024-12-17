using Database;

var empDB = new Employee().GetEmployees();

//query syntax
var employees = (from emp in empDB select emp).ToList();

var custEmp = (from emp in employees
               select new Employee()
               {
                   EmpName = emp.EmpName,
               });



//method syntax 
var methemployees = empDB.Select(emp => emp.EmpId).ToList();
var methCustEmp = empDB.Select(emp => new Employee()
{
    EmpName = emp.EmpName,
});


methCustEmp.ToList().ForEach(emp => Console.WriteLine(emp.EmpName));


//Query Syntax
/* var selectQuery = (from emp in Employee.GetEmployees()
                   select new
                   {
                       EmployeeId = emp.ID,
                       FullName = emp.FirstName + " " + emp.LastName,
                       AnnualSalary = emp.Salary * 12
                   }); */

//Method Syntax
/*  var selectMethod = Employee.Select(emp => new
                                          {
                                              EmployeeId = emp.ID,
                                              FullName = emp.FirstName + " " + emp.LastName,
                                              AnnualSalary = emp.Salary * 12
                                          }).ToList();     */           