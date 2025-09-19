using Amzon_Domain;
using Amazon_Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        using (AmazonDbContext context = new AmazonDbContext())
        {
            context.Database.EnsureCreated();
        }
        addEmployeeTask();
        addEmployee();
        GetEmployee();
        
    }

    private static void addEmployeeTask()
    {
        using var context = new AmazonDbContext();
        AmazonTask tesk = new AmazonTask()
        {
            Name = "Test 1",
            CreateDate = DateTime.Today.AddDays(1),
            CloseDate = DateTime.MinValue,

        };

        AmazonTask tesk2 = new AmazonTask()
        {
            Name = "Test 2",
            CreateDate = DateTime.Today.AddDays(1),
            CloseDate = DateTime.MinValue,

        };
        Employee employee = new();
        employee.Name = "Hassan";
        employee.Email = "Hassan@gmail.com";
        employee.Tasks = new List<AmazonTask> { tesk, tesk2 };
        context.Employees.Add(employee);
        context.SaveChanges();

    }

    private static void addEmployee()
    {
        using var context = new AmazonDbContext();
        Employee employee = new ();
        employee.Name = "Mahmood mustafa Halaj";
        employee.Email = "Mahmood@gmail.com";
        context.Employees.Add(employee);
        context.SaveChanges();

    }

    private static void GetEmployee()
    {
        using var context = new AmazonDbContext();

       var employee =  context.Employees.Include(e => e.Tasks).ToList();

        foreach (var em in employee)
        {
            Console.WriteLine("name " + em.Name + " Email " + em.Email);
            foreach (var tesk in em.Tasks)
            {
                Console.WriteLine("name: " + tesk.Name + (tesk.CloseDate == DateTime.MinValue ? "not done" : "Done"));
            }
        }
        
    }

}