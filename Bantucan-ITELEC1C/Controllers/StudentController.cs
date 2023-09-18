using Microsoft.AspNetCore.Mvc;
using Bantucan_ITELEC1C.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bantucan_ITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
        {
            new Student()
            {
                Id = 1, FirstName = "Toge", LastName = "Inumaki", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "togeinumaki69@gmail.com", PrelimGrade = 92, FinalGrade = 90
            },
            new Student()
            {
                Id = 2, FirstName = "Gon", LastName = "Freecss", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "gonfreecss@gmail.com", PrelimGrade = 90, FinalGrade = 90
            },
            new Student()
            {
                Id = 3, FirstName = "Nagi", LastName = "Seishiro", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "nagishhro@gmail.com", PrelimGrade = 92, FinalGrade = 90
            }
        };

        public IActionResult Index()
        {
            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            // Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null) // Was a student found?
                return View(student);

            return NotFound();
        }
    }
}
