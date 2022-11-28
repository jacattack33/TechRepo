using Microsoft.AspNetCore.Mvc;

namespace SkillsTrackerJacque.Controllers
{
    public class SkillsController : Controller
    {
        [Route("/skills")]
        public IActionResult DisplaySkillsAvailable()
        {
            string html = "<h1>Skills Tracker!</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";

            return Content(html, "text/html");
        }

        [Route("/skills/form")]
        public IActionResult DisplaySkillsForm()
        {
            //return Content(CreateMessage(name, language));
            string html = "<form method='post'>" +
                        "Date:<br>" +
                        "<input type = 'date' name = 'date' />" +
                        "<br>C#:<br>" +
                        "<select name = 'csharpProgress'>" +
                        "<option value = 'learning basics'>Learning basics</option>" +
                        "<option value = 'making apps'>Making apps</option>" +
                        "<option value = 'master coder'>C# coding star</option>" +
                        "</select>" +
                        "<br>JavaScript:<br>" +
                        "<select name = 'jsProgress'>" +
                        "<option value = 'learning basics'>Learning basics</option>" +
                        "<option value = 'making apps'>Making apps</option>" +
                        "<option value = 'master coder'>JavaScript genius</option>" +
                        "</select>" +
                        "<br>Python:<br>" +
                        "<select name = 'pythonProgress'>" +
                        "<option value = 'learning basics'>Learning basics</option>" +
                        "<option value = 'making apps'>Making apps</option>" +
                        "<option value = 'master coder'>Python preeminence</option>" +
                        "</select><br>" +
                        "<input type = 'submit' value = 'Submit' />" +
                        "</form>";

            return Content(html, "text/html");
        }

        [Route("/skills/form")]
        [HttpPost]
        public IActionResult NamePage(string date, string csharpProgress, string jsProgress, string pythonProgress)
        {
            string html = "<h1>" + date + "</h1>" +
                        "<ol>" +
                        "<li>C#: " + csharpProgress + "</li>" +
                        "<li>JavaScript: " + jsProgress + "</li>" +
                        "<li>Python: " + pythonProgress + "</li>" +
                        "</ol>";
            return Content(html, "text/html"); 
        }
    }
}
