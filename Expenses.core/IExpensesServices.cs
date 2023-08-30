using Expense.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.core
{
    public  interface IExpensesServices
    {
        List<Expensetb >GetExpenses();
        Expensetb GetExpenses(int? id);
        Expensetb Create(Expensetb? expenses);
        void DeleteExpenses(Expensetb expense);
        Expensetb EditExpense(Expensetb expense);
    }
}
