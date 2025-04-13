namespace Amzon_Domain
{
    public class Employee
    {
        public Employee()
        {
            Tasks = new List<AmazonTask>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<AmazonTask> Tasks { get; set; }
    }
    

    
}
