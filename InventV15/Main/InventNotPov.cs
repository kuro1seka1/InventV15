using InventV15.Components;

namespace InventV15
{

    public partial class InventNotPov : Form
    {
        readonly InvDbContext context = new();
        public InventNotPov()
        {
            InitializeComponent();
            comboBox1.DataSource = context.Filials.Select(x => x.Filialid).ToList();
            comboBox2.DataSource = context.Cabinets.Select(z => z.Cabinetname).ToList();
            comboBox5.DataSource = context.Services.Select(y => y.Servicename).ToList();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            {

                var SelectedCabinet = comboBox2.SelectedIndex;
                var SelectedFilial = comboBox1.SelectedValue;
                var SelectedService = comboBox5.SelectedIndex;


                Inventory inv = new() { 
                    Inventname = textBox1.Text,
                    Serialnum = textBox2.Text,
                    Filialid = (int)SelectedFilial,
                    Cabinetid = (int)SelectedCabinet + 1,
                    Statusid= 2,
                    Serviceid = (int)SelectedService + 1,
                    Yearofman = dtpYearOfMan.Value.Date.ToUniversalTime() };
                await context.Inventories.AddAsync(inv);
                
                await context.SaveChangesAsync();
                MessageBox.Show("Добавлено!");


            }
        }
    }
}