using Microsoft.AspNetCore.Mvc;
using naukarisarkari.Web.Models;

namespace naukarisarkari.Web.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            // Dummy job data for testing
            var jobs = new List<Job>
            {
                new Job { Id = 1, Title = "Junior Clerk", Department = "MPSC", PostedOn = DateTime.Now.AddDays(-2), ApplyLink = "https://example.com/mpsc" },
                new Job { Id = 2, Title = "Assistant Engineer", Department = "RRB", PostedOn = DateTime.Now.AddDays(-5), ApplyLink = "https://example.com/rrb" },
                new Job { Id = 3, Title = "Bank PO", Department = "IBPS", PostedOn = DateTime.Now.AddDays(-1), ApplyLink = "https://example.com/ibps" }
            };

            return View(jobs);
        }
    }
}
