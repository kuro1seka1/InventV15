using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventV15.Components
{
    class LogerofHistory
    {
       public async void HistoryLogger(string invent, int expath , int inpath)
       {
            InvDbContext db = new();
            string history = $"Прибор {invent} c филиала {expath} переместили в {inpath.ToString()} филиал";
            History historyLog = new History()
            {

                Historydata = history,
            };
            await db.Histories.AddAsync(historyLog);
            await db.SaveChangesAsync();
        }


    }
}
