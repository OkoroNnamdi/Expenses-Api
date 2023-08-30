using Expense.DB;
using Expenses.core;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        private IExpensesServices _ExpensesServices;
        public ExpenseController(IExpensesServices expensesServices)
        {
            _ExpensesServices = expensesServices;
        }
        [HttpGet("GetExpenses")]
        public  IActionResult GetExpenses() 
        {
            var allExpense = _ExpensesServices.GetExpenses();
            return Ok( allExpense);
        }
        [HttpGet("{id}",Name ="GetExpense")]
        public IActionResult GetOneExpense(int id)
        {
            return Ok(_ExpensesServices.GetExpenses(id));
        }
        [HttpPost]
        public IActionResult CreateExpense(Expensetb expense)
        {
            var newExpense = _ExpensesServices.Create(expense);
            return CreatedAtRoute("GetExpense", new {  newExpense.Id},expense );
        }
        [HttpDelete]
        public IActionResult DeleteExpense(Expensetb expense)
        {
            _ExpensesServices.DeleteExpenses(expense);
            return Ok();
        }
        [HttpPut]
        public IActionResult EditExpense(Expensetb expense) 
        { 
            return Ok(_ExpensesServices.EditExpense(expense));
        }
    }
}