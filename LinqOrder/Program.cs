using Database;

var empDB = new Employee().GetEmployees();

//Query Syntax 
var qs = (from emp in empDB
          orderby emp.ProjId, emp.EmpName
          select emp).ToList();

var dqs = (from emp in empDB
           orderby emp.ProjId descending
           select emp);

//Method Syntax 

var ms = empDB.OrderBy(emp => emp.ProjId).ThenBy(emp => emp.EmpName).ThenByDescending(emp => emp.EmpId);
var dms = empDB.OrderByDescending(emp => emp.ProjId);
ms.ToList().ForEach(emp => Console.WriteLine(emp.EmpName));


//Method Syntax
/* var MS = Student.GetAllStudents()
                .Where(std => std.Branch.ToUpper() == "CSE")
                .OrderBy(x => x.FirstName).ToList(); */
//Query Syntax
/* var QS = (from std in Student.GetAllStudents()
          where std.Branch.ToUpper() == "CSE"
          orderby std.FirstName
          select std); */