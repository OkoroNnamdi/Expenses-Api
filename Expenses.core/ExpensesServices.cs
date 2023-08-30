using Expense.DB;
namespace Expenses.core
{
    public class ExpensesServices:IExpensesServices
    {
        private readonly AppDbContext _context;
        public ExpensesServices(AppDbContext context)
        {
            _context = context;
        }
        public Expensetb Create(Expensetb expense)
        {
             _context.Expenses.Add(expense);
            _context .SaveChanges();
            return expense;
        }

        public void DeleteExpenses(Expensetb expense)
        {
            _context .Expenses.Remove(expense);
            _context .SaveChanges();
        }

        public Expensetb EditExpense(Expensetb expense)
        {
            var editExpense = _context.Expenses.First(c=>c.Id == expense.Id);
                editExpense.Amount = expense.Amount;
                editExpense .Description  = expense.Description;
                _context .SaveChanges();
            return editExpense ;
        }

        public List<Expensetb> GetExpenses()
        {
           return _context .Expenses.ToList();
        }
        public Expensetb GetExpenses(int? id)
        {
            return _context.Expenses.FirstOrDefault(c => c.Id == id);
        }
    }

}