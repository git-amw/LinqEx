int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };

// ------------------ SUM ----------------------
//Using Method Syntax
int MSTotal = intNumbers.Sum();


//Using Query Syntax
int QSTotal = (from num in intNumbers
               select num).Sum();


//Using Method Syntax
/* var TotalSalaryMS = Employee.GetAllEmployees()
                  .Where(emp => emp.Department == "IT")
                  .Sum(emp => emp.Salary); */

//Using Query Syntax
/* var TotalSalaryQS = (from emp in Employee.GetAllEmployees()
                     where emp.Department == "IT"
                     select emp).Sum(e => e.Salary); */


// ----------------- MAX ---------------------------------

//Using Method Syntax
int MSLergestNumber = intNumbers.Max();

//Using Query Syntax
int QSLergestNumber = (from num in intNumbers
                       select num).Max();

//Using Method Syntax
/* var MSHighestSalary = Employee.GetAllEmployees()
                  .Where(emp => emp.Department == "IT")
                  .Max(emp => emp.Salary); */

//Using Query Syntax
/* var QSHighestSalary = (from emp in Employee.GetAllEmployees()
                       where emp.Department == "IT"
                       select emp).Max(e => e.Salary); */

// ---------------- MIN ------------------------------------------------

//Using Method Syntax
int MSLowestNumber = intNumbers.Min();

//Using Query Syntax
int QSLowestNumber = (from num in intNumbers
                      select num).Min();

//Using Method Syntax
/* var MSLowestSalary = Employee.GetAllEmployees()
                     .Where(emp => emp.Department == "IT")
                     .Min(emp => emp.Salary); */

//Using Query Syntax
/* var QSLowestSalary = (from emp in Employee.GetAllEmployees()
                      where emp.Department == "IT"
                      select emp).Min(e => e.Salary); */

//---------------- AVG--------------------------------------------

//Using Method Syntax
var MSAverageValue = intNumbers.Average();

//Using Query Syntax
var QSAverageValue = (from num in intNumbers
                      select num).Average();

//Using Method Syntax
/* var MSAverageSalary = Employee.GetAllEmployees()
                     .Where(emp => emp.Department == "IT")
                     .Average(emp => emp.Salary); */


//Using Query Syntax
/* var QSAverageSalary = (from emp in Employee.GetAllEmployees()
                       where emp.Department == "IT"
                       select emp).Average(e => e.Salary); */


// ----------------------- COUNT -----------------------------------

//Using Method Syntax
int MSCount = intNumbers.Count();

//Using Query Syntax
var QSCount = (from num in intNumbers
               select num).Count();

//Using Method Syntax
/* var MSCount = Employee.GetAllEmployees()
              .Where(emp => emp.Department == "IT")
              .Count(); */


//Using Query Syntax
/* var QSCount = (from emp in Employee.GetAllEmployees()
               where emp.Department == "IT"
               select emp).Count(); */