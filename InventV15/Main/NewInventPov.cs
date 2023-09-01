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
    public partial class NewInventPov : Form
    {
        InvDbContext context = new();
        public NewInventPov()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Inventtype invtype = new() { Inventname = tbxName.Text };
            await context.Inventtypes.AddAsync(invtype);
            await context.SaveChangesAsync();
            MessageBox.Show("Добавлено!");
        }
    }
}
