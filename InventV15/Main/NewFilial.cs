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

namespace InventV15
{
    public partial class NewFilial : Form
    {
        InvDbContext context = new();
        public NewFilial()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int numfill = (int)numFilNum.Value;
            Filial filial = new() { Filialid = numfill, Filialname = tbxAdr.Text };
            await context.Filials.AddAsync(filial);
            await context.SaveChangesAsync();
            MessageBox.Show("Добавено!");
        }
    }
}
