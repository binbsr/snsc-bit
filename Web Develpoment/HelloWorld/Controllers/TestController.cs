using Microsoft.AspNetCore.Mvc;
public class TestController: Controller
{
    public DateTime CurrentDate()
    {
        return DateTime.Now;
    }

    public string Hi()
    {
        return "Hi guys!!!";
    }

    public IActionResult ListPeople()
    {
        return View();
    }
}