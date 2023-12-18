﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Models
{
    public class Employee 
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public decimal Salary {  get; set; }
        public string Department {  get; set; }
        public char Gender {  get; set; }
    }
}
