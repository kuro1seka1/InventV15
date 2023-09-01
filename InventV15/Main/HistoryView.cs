using InventV15.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventV15.Main
{
    public partial class HistoryView : Form
    {
        readonly InvDbContext context = new();
        public HistoryView()
        {
            InitializeComponent();
            dataGridViewHistory.AutoResizeRows(
            DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            this.dataGridViewHistory.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;
            dataGridViewHistory.DataSource = context.Histories.Select(x => new
            {
                id = x.Historyid,
                name = x.Historydata,
            }
            ).ToList();
            dataGridViewHistory.Columns[0].HeaderText = "Номер";
            dataGridViewHistory.Columns[1].HeaderText = "Перемещения";

        }
    }
}
