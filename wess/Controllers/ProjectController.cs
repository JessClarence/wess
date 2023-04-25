using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wess.Data;
using wess.Models;

namespace wess.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertRecord(string cardid)
        {
            var log = new Rfid
            {
                CardId = cardid,
                LogDate = DateTime.Now
            };

            if (string.IsNullOrEmpty(cardid))
            {
                // Handle the error here - throw an exception, return an error response, etc.
                return Json("Card ID cannot be null or empty");
            }

            _context.RFIDs.Add(log);
            _context.SaveChanges();

            return Json("success");
        }

        [HttpPost]
        public IActionResult ShowProcess()
        {
            var logs = _context.RFIDs.ToList();

            return PartialView("_RfidLogPartial", logs);
        }
    }
}
