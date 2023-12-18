using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;
using System.Linq;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmployee);
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = Repository.AllEmployee.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Update(string empname)
        {
            Employee employee = Repository.AllEmployee.Where(e=>e.Name==empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee,string empname)
        {
            Repository.AllEmployee.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            Repository.AllEmployee.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            Repository.AllEmployee.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            Repository.AllEmployee.Where(e => e.Name == empname).FirstOrDefault().Gender = employee.Gender;
            return RedirectToAction("Index");
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repository.Create(employee);
            return View("Success",employee);
        }

        

    }
}
