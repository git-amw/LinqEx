namespace Database;

public class Project
{
    public int ProjId { get; set; }
    public string ProjName { get; set; }

    public static IList<Project> GetProjects()
    {
        return new List<Project>() {
            new Project() { ProjId = 100, ProjName = "ABC" },
            new Project() { ProjId = 200, ProjName = "EFG" },
            new Project() { ProjId = 300, ProjName = "JKI" },
            new Project() { ProjId = 400, ProjName = "LMN" }
        };
    }
}
