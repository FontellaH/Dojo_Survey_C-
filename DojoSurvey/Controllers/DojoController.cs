
using Microsoft.AspNetCore.Mvc;// #10 importing route
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace NewWeb.Controllers;  //#11  keeps the controllers talking to each other

public class DojoController : Controller

{

    [HttpGet]  /// #13 showing im about to write a action
    [Route("")]   // #14 Has a empty base route
    public ViewResult DojoForm()  // #15writing the function here for the base route
    {
        return View("DojoForm");
    }


    [HttpGet("results")]
    public ViewResult DojoResult()
    {
        return View();  //rendering the page
    }


 [HttpPost("process")]   // This makes the post for the form
public ViewResult Process(string name, string location, string language, string textarea)
{
    ViewBag.name = name;
    ViewBag.location = location;
    ViewBag.language = language;
    ViewBag.textarea = textarea;

    return View("DojoResult");
}
    }


