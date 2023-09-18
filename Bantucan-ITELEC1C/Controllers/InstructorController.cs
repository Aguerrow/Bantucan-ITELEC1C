using Microsoft.AspNetCore.Mvc;
using Bantucan_ITELEC1C.Models;


namespace Bantucan_ITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Light",LastName = "Yagami", Rank =  Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Lelouch",LastName = "Lamperouge", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = true
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Levi",LastName = "Ackerman", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25"), IsTenured = false
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);

            return View("Index", InstructorList);
        }
        public IActionResult Edit(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null) // Was a student found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);
            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.LastName = instructorChange.LastName;
                instructor.FirstName = instructorChange.FirstName;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
                instructor.IsTenured = instructorChange.IsTenured;

            }
            return View("Index", InstructorList);

        }
    }
}
