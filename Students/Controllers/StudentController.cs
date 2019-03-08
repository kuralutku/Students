using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Models;
using Microsoft.AspNetCore.Mvc;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>();

        public StudentController()
        {
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Utku";
            student1.Surname = "Kural";
            student1.adress = "yasarbey sok.";
            students.Add(student1);
        }

        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Info(int id)
        {
            Student student = new Student();
            if (id == 1)
            {
                student.Name = "Utku";
                student.Surname = "Kural";
                student.adress = "yasarbey sok.";
            }
            else
            {
                return NotFound();
            }

            return View(student);
        }
    }
}