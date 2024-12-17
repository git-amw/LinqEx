namespace Database;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int ProjId { get; set; }

    public static IList<Employee> GetEmployees()
    {
        return new List<Employee>()
        {
            new Employee() { EmpId = 1, EmpName = "Emp1", ProjId = 100 },
            new Employee() { EmpId = 2, EmpName = "Emp2", ProjId = 200 },
            new Employee() { EmpId = 3, EmpName = "Emp3", ProjId = 100 },
            new Employee() { EmpId = 4, EmpName = "Emp4", ProjId = 300 },
            new Employee() { EmpId = 5, EmpName = "Emp5", ProjId = 600 },
            new Employee() { EmpId = 6, EmpName = "Emp6", ProjId = 400 }

        };
    }
}
