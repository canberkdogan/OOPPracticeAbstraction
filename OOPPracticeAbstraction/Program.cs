using OOPPracticeAbstraction;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create an instance of SoftwareDeveloper and set its properties
        Employee softwareDeveloper = new SoftwareDeveloper { Name = "Canberk", Surname = "Doğan", Departmant = "Software" };

        // Create an instance of ProjectManager and set its properties
        Employee projectManager = new ProjectManager { Name = "Ceyda", Surname = "Yılmaz", Departmant = "Project" };

        // Create an instance of SalesRepresentative and set its properties
        Employee salesRepresentative = new SalesRepresentative { Name = "Furkan", Surname = "Coşkun", Departmant = "Sales" };

        // Call the Mission method for each employee, which outputs their specific role
        softwareDeveloper.Mission();
        projectManager.Mission();
        salesRepresentative.Mission();
    }
}

