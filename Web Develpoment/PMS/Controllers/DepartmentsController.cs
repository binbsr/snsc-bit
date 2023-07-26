using Microsoft.AspNetCore.Mvc;
public class DepartmentsController : Controller
{
    static List<Department> departments = new()
        {
            new Department { Id = 1, Name = "OPD", Description = "It's outpatient department.", Established = new DateTime(2010, 12, 12)},
            new Department { Id = 2, Name = "Dental", Description = "It's dental department.", Established = new DateTime(2012, 1, 22)},
            new Department { Id = 3, Name = "Lab", Description = "It's lab test department.", Established = new DateTime(2015, 6, 10)}
        };

    [HttpGet]
    public IActionResult Index()
    {
        // Fetch list of departments       

        return View(departments);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Department department)
    {
        departments.Add(department);

        return RedirectToAction("Index");
    }
}