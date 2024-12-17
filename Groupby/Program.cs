using Database;

var studDB = Student.GetAllStudents();


//Query syntax
var qgp = (from stud in studDB
           group stud by stud.Branch);


//Method Syntax 
var mgp = studDB.GroupBy(stud => stud.Branch);

/* mgp.ToList().ForEach(mgp =>
{
    Console.WriteLine(mgp.Key + " " + mgp.Count());
    foreach (var stu in mgp)
    {
        Console.WriteLine("Name " + stu.FirstName + " " + stu.LastName);
    }
}); */



// query syntax 
var nqs = (from stu in studDB
           group stu by stu.Branch into stug
           select new
           {
               Key = stug.Key,
               Student = (from stu in stug select stu.FirstName).ToList(),
           }
);

var nms = studDB.GroupBy(stu => stu.Branch).Select(stu => new
{
    Key = stu.Key,
    Student = stu.Select(s => s.FirstName).ToList(),
});