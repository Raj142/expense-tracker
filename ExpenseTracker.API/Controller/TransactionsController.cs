using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.API.Models;
using ExpenseTracker.API.Data;

namespace ExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactions = _context.Transactions.ToList();
            return Ok(transactions);
        }

        [HttpPost]
        public IActionResult Add(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return Ok(transaction);
        }
    }
}
