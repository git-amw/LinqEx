using Database;

var empDB = Employee.GetEmployees();
var projDB = Project.GetProjects();


//Method syntax
var mjoin = empDB.Join(
    projDB,
    emp => emp.ProjId,
    proj => proj.ProjId,
    (emp, proj) => new
    {
        EmployeeName = emp.EmpName,
        ProjectName = proj.ProjName,
    }
).ToList();

// mjoin.ForEach(joinData => Console.WriteLine(joinData.EmployeeName + " " + joinData.ProjectName));

//Query syntax 
var qjoin = (from emp in empDB
             join proj in projDB
             on emp.ProjId equals proj.ProjId
             select new
             {
                 EmployeeName = emp.EmpName,
                 ProjectName = proj.ProjName,
             }
).ToList();



// Query syntax
/* var JoinMultipleDSUsingQS = (from emp in Employee.GetAllEmployees()
                                join adrs in Address.GetAllAddresses()
                                on emp.AddressId equals adrs.ID
                                join dept in Department.GetAllDepartments()
                                on emp.DepartmentId equals dept.ID
                                select new
                                {
                                    ID = emp.ID,
                                    EmployeeName = emp.Name,
                                    DepartmentName = dept.Name,
                                    AddressLine = adrs.AddressLine
                                }).ToList(); */


//Method Syntax
/* var JoinMultipleDSUsingMS = Employee.GetAllEmployees().Join(
                                    Address.GetAllAddresses(), //Inner Data Source 1
                                    empLevel1 => empLevel1.AddressId, //Outer Key selector
                                    addLevel1 => addLevel1.ID, //Inner Key selector
                                    //Result set
                                    (empLevel1, addLevel1) => new { empLevel1, addLevel1 }
                                    )
                                    // Joinging with Department Data Source (i.e. data Source 3)
                                    .Join(
                                            Department.GetAllDepartments(), //Inner Data Source 2
                                            //You cannot access the outer key selector directly
                                            //You can only access with the result set created in previous step
                                            //i.e. using empLevel1 and addLevel1
                                            empLevel2 => empLevel2.empLevel1.DepartmentId, //Outer Key selector
                                            deptLevel1 => deptLevel1.ID, //Inner Key selector
                                            //Result set
                                            (empLevel2, deptLevel1) => new { empLevel2, deptLevel1 }
                                    )
                                    //Creating the actual result set
                                    .Select(e => new
                                    {
                                        ID = e.empLevel2.empLevel1.ID,
                                        EmployeeName = e.empLevel2.empLevel1.Name,
                                        AddressLine = e.empLevel2.addLevel1.AddressLine,
                                        DepartmentName = e.deptLevel1.Name
                                    }).ToList(); */

//------------------ Left / Right OuterJoin -----------------------------------------

//Query syntax

var qLeftJoin = (from emp in empDB
                 join proj in projDB
                 on emp.ProjId equals proj.ProjId
                 into empProj
                 from proj in empProj.DefaultIfEmpty()
                 select new { emp, proj }).ToList();

/* foreach (var item in qLeftJoin)
{
    Console.WriteLine($"Name : {item.emp.EmpName}  Project : {item.proj?.ProjName}");
} */


var crossJoin = (from emp in empDB
                 from proj in projDB
                 select new
                 {
                     EmpName = emp.EmpName,
                     ProjName = proj.ProjName,
                 }).ToList();

// crossJoin.ForEach(item => Console.WriteLine(item.EmpName + " " + item.ProjName));