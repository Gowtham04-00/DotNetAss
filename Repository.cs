using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Models
{
    public class Repository : Controller
    {
        private static List<Employee> allEmployee=new List<Employee>();
        public static IEnumerable<Employee> AllEmployee
        {
           get{ return allEmployee; }
        }

        public static void Create(Employee employee)
        {
            allEmployee.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            allEmployee.Remove(employee);
        }
    }
}
