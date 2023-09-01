using InventV15.Components;

namespace InventV15
{
    public partial class InvetnPov : Form
    {
        InvDbContext ct = new();

        public InvetnPov()
        {

            InitializeComponent();
            var inventtest = ct.Inventtypes.ToList();
            comboBox1.DataSource = ct.Filials.Select(x => x.Filialid).ToList();
           var id =  inventtest.Select(x=>x.Inventtypeid).ToList();
            
            var name = inventtest.Select(x=>x.Inventname).ToList();
            
            comboBox2.DataSource = name;
            comboBox3.DataSource = ct.Cabinets.Select(x => x.Cabinetname).ToList();
            comboBox4.DataSource = ct.Statuses.Select(x => x.Statusname).ToList();


        }

        private async void Button1_Click(object sender, EventArgs e)
        {


            var SelectedFilial = (int)comboBox1.SelectedValue;
            var SelectedInventoryType = (int)comboBox2.SelectedIndex;
            var SelectedCabinet = Convert.ToInt16(comboBox3.SelectedValue);
            var SelectedStatus = (int)comboBox4.SelectedIndex;
            //1,2,4,5,6 - 1 year
            //3,8 - 2 year 
            //7 - year
            if (SelectedInventoryType == 1 || SelectedInventoryType == 5 || SelectedInventoryType == 6 || SelectedInventoryType == 7 || SelectedInventoryType == 10)
            {

                Inventory inv = new() { 

                    Inventname = textBox1.Text,
                    Serialnum = textBox2.Text,
                    Datepov = dateTimePicker1.Value.Date.ToUniversalTime(),
                    Datenextpov = dateTimePicker1.Value.Date.AddYears(1).ToUniversalTime(),
                    Filialid = SelectedFilial,
                    Inventtype = SelectedInventoryType+1,
                    Cabinetid = SelectedCabinet,
                    Serviceid = 1, 
                    Statusid = SelectedStatus + 1,
                    Yearofman = dateTimePicker3.Value.Date.ToUniversalTime()
                };
                 ct.Inventories.Add(inv);
                await ct.SaveChangesAsync();
            }
            else if (SelectedInventoryType == 2 || SelectedInventoryType == 8 || SelectedInventoryType == 3 )
            {
                Inventory inv = new() {
                    Inventname = textBox1.Text,
                    Serialnum = textBox2.Text,
                    Datepov = dateTimePicker1.Value.Date.ToUniversalTime(),
                    Datenextpov = dateTimePicker1.Value.Date.AddYears(2).ToUniversalTime(),
                    Filialid = SelectedFilial , 
                    Inventtype = SelectedInventoryType+1,
                    Cabinetid = SelectedCabinet,
                    Serviceid = 1,
                    Statusid = SelectedStatus +1 ,
                    Yearofman = dateTimePicker3.Value.Date.ToUniversalTime()
                };
                await ct.Inventories.AddAsync(inv);
                await ct.SaveChangesAsync();
            }
            else
            {
                Inventory inv = new() { Inventname = textBox1.Text,
                    Serialnum = textBox2.Text,
                    Datepov = dateTimePicker1.Value.Date.ToUniversalTime(),
                    Datenextpov = dateTimePicker1.Value.Date.AddYears(3).ToUniversalTime(),
                    Filialid = SelectedFilial,
                    Inventtype = SelectedInventoryType +1, 
                    Cabinetid = SelectedCabinet, 
                    Serviceid = 1,
                    Statusid = SelectedStatus + 1, 
                    Yearofman = dateTimePicker3.Value.Date.ToUniversalTime()
                };
                await ct.Inventories.AddAsync(inv);
                await ct.SaveChangesAsync();
            }


            TopMost = true;
            MessageBox.Show("Добавлено!");
            TopMost = false;



        }
    }
}
