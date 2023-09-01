

using Microsoft.EntityFrameworkCore;
using InventV15.Components;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using InventV15.Main;

namespace InventV15
{
    public partial class StartPage : Form
    {
        readonly InvDbContext context = new();

        public StartPage()
        {

            InitializeComponent();
            dataGridView1.AutoResizeRows(
            DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            this.dataGridView1.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;
            searchByFilial.DataSource = context.Filials.Select(x => x.Filialname).ToList();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblTypename.Visible = true;
            cbxTypename.Visible = true;

            lblname.Visible = true;
            tbxName.Visible = true;

            lblSerialnum.Visible = true;
            tbxSerialnum.Visible = true;

            lblDatepov.Visible = true;
            dtpDatepov.Visible = true;

            lblDatenextpov.Visible = true;
            dtpDatenextpov.Visible = true;

            lblFilial.Visible = true;
            cbxFilial.Visible = true;

            lblCabnum.Visible = true;
            cbxCabnum.Visible = true;

            lblStatus.Visible = true;
            cbxStatus.Visible = true;

            lblService.Visible = true;
            cbxService.Visible = true;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;

            lblYearOfMan.Visible = true;
            dtpYearOfMan.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            searchByFilial.Enabled = false;
            Start();
        }
        public void Start()
        {
            InvDbContext db = new InvDbContext();
            dataGridView1.DataSource = db.Inventories.Select(x => new
            {
                id = x.Inventid,
                name = x.Inventname,
                serial = x.Serialnum,
                datepov = x.Datepov,
                datenextpov = x.Datenextpov,
                filial = x.Filial.Filialname,
                status = x.Status.Statusname,
                service = x.Service.Servicename,
                yearofman = x.Yearofman,
                type = x.Inventtype,
                cabinet = x.Cabinet.Cabinetname
            }).ToList();

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Серийный номер";
            dataGridView1.Columns[3].HeaderText = "Дата поверки";
            dataGridView1.Columns[4].HeaderText = "Дата следующей поверки";
            dataGridView1.Columns[5].HeaderText = "Филиал";
            dataGridView1.Columns[6].HeaderText = "Статус";
            dataGridView1.Columns[7].HeaderText = "Обслуживание";
            dataGridView1.Columns[8].HeaderText = "Год выпуска";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Номер кабинета";





        }
        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {

        }
        // удаление
        public void Deleting(bool dialog)
        {
            InvDbContext db = new InvDbContext();
            if (dialog == true)
            {

                DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этот элемент?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.ServiceNotification);

                if (result == DialogResult.Yes)
                {
                    //получение  ID  прибора
                    var p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    //Выбор по ID
                    Inventory? inv = db.Inventories.FirstOrDefault(c => c.Inventid == p);
                    if (inv != null)
                    {
                        db.Remove(inv);
                        db.SaveChangesAsync();

                        TopMost = true;
                        MessageBox.Show("Успешно удалено!");
                        TopMost = false;
                        Start();

                    }
                }
            }
            else
            {

                var p = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                //Выбор по ID
                Inventory? inv = db.Inventories.FirstOrDefault(c => c.Inventid == p);
                if (inv != null)
                {
                    db.Remove(inv);
                    db.SaveChangesAsync();
                    Start();

                }

            }


        }
        // поиск 
        public void Searching()
        {
            // определяем символы которые должны удаляться при входе в функцию
            char[] charsToTrim = { ' ', '\n', 't', '"', '\"' };
            string? searching = textBox1.Text.Trim();
            // удаляем эти символы
            string? trimmed = searching.Trim(charsToTrim);
            if (string.IsNullOrEmpty(trimmed))
            {
                MessageBox.Show("Введите символы для поиска");
            }
            else
            {
                var t = context.Inventories.Select(x => new
                {
                    id = x.Inventid,
                    name = x.Inventname,
                    serial = x.Serialnum,
                    datepov = x.Datepov,
                    datenextpov = x.Datenextpov,
                    filial = x.Filial.Filialname,
                    status = x.Status.Statusname,
                    service = x.Service.Servicename,
                    yearofman = x.Yearofman,
                    type = x.Inventtype
                }).AsEnumerable().Where(
                   x => x.name.Trim(charsToTrim).StartsWith(trimmed, true, null)
                  || x.serial.Trim(charsToTrim).StartsWith(trimmed, true, null)
                  || x.serial.Trim(charsToTrim).EndsWith(trimmed, true, null)
                  || x.name.Trim(charsToTrim).EndsWith(trimmed, true, null))
                  .ToList();
                dataGridView1.DataSource = t;
                if (t.Count == 0)
                {
                    TopMost = true;
                    MessageBox.Show("Ничего не найдено!");
                    TopMost = false;
                }
            }
        }
        // добавление в форму для редактирования 
        public void Pushing()
        {

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            // заполняем ячейки информацией из таблицы 
            tbxName.Text = (dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
            tbxSerialnum.Text = (dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
            cbxFilial.DataSource = context.Filials.Select(x => x.Filialname).ToList();
            cbxCabnum.DataSource = context.Cabinets.Select(x => x.Cabinetname).ToList();
            cbxStatus.DataSource = context.Statuses.Select(x => x.Statusname).ToList();
            cbxService.DataSource = context.Services.Select(x => x.Servicename).ToList();
            cbxTypename.DataSource = context.Inventtypes.Select(x => x.Inventname).ToList();



            DateTime? datepov_parse = (DateTime?)dataGridView1[3, dataGridView1.CurrentRow.Index].Value;
            DateTime? datenextpov_parse = (DateTime?)dataGridView1[4, dataGridView1.CurrentRow.Index].Value;



            // если это поверяемый элемент то выполняется эта часть 
            if (datepov_parse.HasValue & datenextpov_parse.HasValue)
            {
                var type_parse = Convert.ToInt32(dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString());
                var type = context.Inventtypes.Where(x => x.Inventtypeid == type_parse).Select(x => x.Inventname).ToList();
                cbxTypename.DataSource = type;



                var filial_parse = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                var filial = context.Filials.Where(x => x.Filialname == filial_parse).Select(x => x.Filialname).ToList();
                cbxFilial.DataSource = filial;


                dtpDatepov.Value = (DateTime)dataGridView1[3, dataGridView1.CurrentRow.Index].Value;
                dtpDatenextpov.Value = (DateTime)dataGridView1[4, dataGridView1.CurrentRow.Index].Value;
                dtpYearOfMan.Value = (DateTime)dataGridView1[8, dataGridView1.CurrentRow.Index].Value;

                var t = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                cbxStatus.DataSource = context.Statuses.Where(x => x.Statusname == t)
                    .Select(z => z.Statusname).ToList();
                dtpDatepov.Enabled = true;
                dtpDatenextpov.Enabled = false;
                cbxStatus.Enabled = true;
                cbxService.Enabled = false;
            }
            // если поверяемый элемент то выполняется эта часть 
            else
            {

                var type = context.Inventtypes.Where(x => x.Inventtypeid == 0).ToList();
                cbxTypename.DataSource = type;
                var y = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                cbxService.DataSource = context.Services.Where(x => x.Servicename == y)
                    .Select(z => z.Servicename).ToList();
                var filial_parse = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                var filial = context.Filials.Where(x => x.Filialname == filial_parse).Select(x => x.Filialname).ToList();
                cbxFilial.DataSource = filial;
                dtpYearOfMan.Value = (DateTime)dataGridView1[8, dataGridView1.CurrentRow.Index].Value;
                cbxTypename.Enabled = false;
                dtpDatepov.Enabled = false;
                dtpDatenextpov.Enabled = false;
                cbxStatus.Enabled = false;
                cbxService.Enabled = true;


            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение для работы с таблицой поверки приборов");
        }

        private void PovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InvetnPov().ShowDialog();
        }
        private void NotPovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventNotPov().ShowDialog();
        }

        // обновление в БД данных о приборе
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using InvDbContext db = new InvDbContext();
            LogerofHistory logerofHistory = new LogerofHistory();
            var filial_parse_to_to_tohistiry = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            var filial_tohistiry = context.Filials.FirstOrDefault(x => x.Filialname == filial_parse_to_to_tohistiry).Filialid;

            var expath = filial_tohistiry;
            DialogResult result = MessageBox.Show(
           "Вы действительно хотите обновить этот элемент?",
           "Сообщение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);

            DateTime? datepov_parse = (DateTime?)dataGridView1[3, dataGridView1.CurrentRow.Index].Value;
            DateTime? datenextpov_parse = (DateTime?)dataGridView1[4, dataGridView1.CurrentRow.Index].Value;

            if (result == DialogResult.Yes)
            {

                if (datepov_parse.HasValue & datenextpov_parse.HasValue)
                {
                    //сортировака по сроку поверки 
                    var filial_parse = cbxFilial.SelectedValue;
                    var filial = context.Filials.FirstOrDefault(x => x.Filialname == filial_parse).Filialid;
                    Convert.ToInt32(filial);
                    var SelectedFilial = filial;
                    var type_parse = cbxTypename.SelectedItem;


                    var SelectedInventoryType = context.Inventtypes.FirstOrDefault(x => x.Inventname == type_parse).Inventtypeid;
                    var SelectedCabinet = Convert.ToInt16(cbxCabnum.SelectedValue);
                    var SelectedStatus = (int)cbxStatus.SelectedIndex;
                    //1,2,4,5,6 - 1 year
                    //3,8 - 2 year 
                    //7 - year
                    if (SelectedInventoryType == 2 || SelectedInventoryType == 8 || SelectedInventoryType == 6 || SelectedInventoryType == 7 || SelectedInventoryType == 10)
                    {

                        Inventory inv = new()
                        {
                            Inventname = tbxName.Text,
                            Serialnum = tbxSerialnum.Text,
                            Datepov = dtpDatepov.Value.Date.ToUniversalTime(),
                            Datenextpov = dtpDatepov.Value.Date.AddYears(1).ToUniversalTime(),// im here 
                            Filialid = SelectedFilial,
                            Inventtype = SelectedInventoryType,
                            Cabinetid = SelectedCabinet,
                            Serviceid = 1,
                            Statusid = SelectedStatus + 1,
                            Yearofman = dtpYearOfMan.Value.Date.ToUniversalTime()
                        };

                        // тут что то не так

                        string invent = inv.Inventname;
                        context.Inventories.Update(inv);


                        Deleting(false);
                        await context.SaveChangesAsync();

                        int inpath = SelectedFilial;
                        logerofHistory.HistoryLogger(invent, expath, inpath);
                        TopMost = true;
                        MessageBox.Show("Успешно обновлено !");
                        TopMost = false;


                    }
                    else if (SelectedInventoryType == 9 || SelectedInventoryType == 4 || SelectedInventoryType == 3)
                    {
                        Inventory inv = new()
                        {
                            Inventname = tbxName.Text,
                            Serialnum = tbxSerialnum.Text,
                            Datepov = dtpDatepov.Value.Date.ToUniversalTime(),
                            Datenextpov = dtpDatepov.Value.Date.AddYears(2).ToUniversalTime(),
                            Filialid = SelectedFilial,
                            Inventtype = SelectedInventoryType,
                            Cabinetid = SelectedCabinet,
                            Serviceid = 1,
                            Statusid = SelectedStatus + 1,
                            Yearofman = dtpYearOfMan.Value.Date.ToUniversalTime()
                        };

                        string invent = inv.Inventname;
                        context.Inventories.Update(inv);


                        Deleting(false);
                        await context.SaveChangesAsync();

                        int inpath = SelectedFilial;
                        logerofHistory.HistoryLogger(invent, expath, inpath);
                        TopMost = true;
                        MessageBox.Show("Успешно обновлено !");
                        TopMost = false;

                    }
                    else if (SelectedInventoryType == 1)
                    {
                        MessageBox.Show("Нет поверочного интервала, измените тип оборудования");
                    }


                    else
                    {
                        Inventory inv = new()
                        {
                            Inventname = tbxName.Text,
                            Serialnum = tbxSerialnum.Text,
                            Datepov = dtpDatepov.Value.Date.ToUniversalTime(),
                            Datenextpov = dtpDatepov.Value.Date.AddYears(3).ToUniversalTime(),
                            Filialid = SelectedFilial,
                            Inventtype = SelectedInventoryType,
                            Cabinetid = SelectedCabinet,
                            Serviceid = 1,
                            Statusid = SelectedStatus + 1,
                            Yearofman = dtpYearOfMan.Value.Date.ToUniversalTime()
                        };


                        string invent = inv.Inventname;
                        context.Inventories.Update(inv);


                        Deleting(false);
                        await context.SaveChangesAsync();

                        int inpath = SelectedFilial;
                        logerofHistory.HistoryLogger(invent, expath, inpath);
                        TopMost = true;
                        MessageBox.Show("Успешно обновлено !");
                        TopMost = false;

                    }
                }
                //без поверкии
                else
                {

                    var filial_parse = cbxFilial.SelectedValue;
                    var filial = context.Filials.FirstOrDefault(x => x.Filialname == filial_parse).Filialid;
                    Convert.ToInt32(filial);
                    var SelectedFilial = filial;
                    var SelectedCabinet = Convert.ToInt16(cbxCabnum.SelectedValue);
                    var SelectedService = (int)cbxService.SelectedIndex;

                    //1,2,4,5,6 - 1 year
                    //3,8 - 2 year 
                    //7 - year


                    Inventory inv = new()
                    {
                        Inventname = tbxName.Text,
                        Serialnum = tbxSerialnum.Text,
                        Filialid = SelectedFilial,
                        Cabinetid = SelectedCabinet,
                        Serviceid = SelectedService + 1,
                        Statusid = 2,
                        Yearofman = dtpYearOfMan.Value.Date.ToUniversalTime()
                    };


                    string invent = inv.Inventname;
                    context.Inventories.Update(inv);


                    Deleting(false);
                    await context.SaveChangesAsync();

                    int inpath = SelectedFilial;
                    logerofHistory.HistoryLogger(invent, expath, inpath);
                    TopMost = true;
                    MessageBox.Show("Успешно обновлено !");
                    TopMost = false;





                    Start();
                }

            }
        }

        //отображение кнопок и поле по двойному клиику


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Deleting(true);
        }

        private void NewInventPovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewInventPov().ShowDialog();
        }
        private void filialtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new NewFilial().ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                searchByFilial.Enabled = true;

            }
            else
            {
                searchByFilial.Enabled = false;
            }
        }

        private void searchByFilial_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedFilial = searchByFilial.Text;
            var t = context.Inventories.Select(x => new
            {
                id = x.Inventid,
                name = x.Inventname,
                serial = x.Serialnum,
                datepov = x.Datepov,
                datenextpov = x.Datenextpov,
                filial = x.Filial.Filialname,
                status = x.Status.Statusname,
                service = x.Service.Servicename,
                yearofman = x.Yearofman,
                type = x.Inventtype,
                cabinet = x.Cabinetid

            }).AsEnumerable().Where(x => x.filial == selectedFilial)
              .ToList();
            dataGridView1.DataSource = t;
        }

        private void FilterService(string currentService)
        {
            var filtered = context.Inventories.Select(x => new
            {
                id = x.Inventid,
                name = x.Inventname,
                serial = x.Serialnum,
                datepov = x.Datepov,
                datenextpov = x.Datenextpov,
                filial = x.Filial.Filialname,
                status = x.Status.Statusname,
                service = x.Service.Servicename,
                yearofman = x.Yearofman,
                type = x.Inventtype,
                cabinet = x.Cabinetid
            }).AsEnumerable().Where(x => x.service == currentService)
            .ToList();
            dataGridView1.DataSource = filtered;
        }
        private void FilterStatus(string currentStatus)
        {
            var filtered = context.Inventories.Select(x => new
            {
                id = x.Inventid,
                name = x.Inventname,
                serial = x.Serialnum,
                datepov = x.Datepov,
                datenextpov = x.Datenextpov,
                filial = x.Filial.Filialname,
                status = x.Status.Statusname,
                service = x.Service.Servicename,
                yearofman = x.Yearofman,
                type = x.Inventtype,
                cabinet = x.Cabinetid
            }).AsEnumerable().Where(x => x.status == currentStatus)
            .ToList();
            dataGridView1.DataSource = filtered;
        }
        // переменные относящиеся к сортировке
        private string[] statuses;
        private int currentStatus;

        private string[] services;
        private int currentService;

        private void SwitchService()
        {
            services = context.Services.Select(x => x.Servicename).ToArray();
            currentService = (currentService + 1) % services.Length;
        }
        private void SwitchStatus()
        {
            statuses = context.Statuses.Select(x => x.Statusname).ToArray();
            currentStatus = (currentStatus + 1) % statuses.Length;
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            while (e.ColumnIndex != 6 || e.ColumnIndex != 7)
            {
                Start();
                break;
            }

            if (e.ColumnIndex == 6)
            {
                SwitchStatus();
                FilterStatus(statuses[currentStatus]);
            }

            else if (e.ColumnIndex == 7)
            {
                SwitchService();
                FilterService(services[currentService]);
            }


        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pushing();
        }

        private void StartPage_Activated(object sender, EventArgs e)
        {
            Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searching();
                e.Handled = true;
            }
        }

        private void cbxTypename_Click(object sender, EventArgs e)
        {
            cbxTypename.DataSource = context.Inventtypes.Select(x => x.Inventname).ToList();
        }

        private void cbxFilial_Click(object sender, EventArgs e)
        {
            cbxFilial.DataSource = context.Filials.Select(x => x.Filialname).ToList();
        }

        private void cbxStatus_Click(object sender, EventArgs e)
        {
            cbxStatus.DataSource = context.Statuses.Select(x => x.Statusname).ToList();
        }

        private void cbxService_Click(object sender, EventArgs e)
        {
            cbxService.DataSource = context.Services.Select(x => x.Servicename).ToList();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void HistiryMovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HistoryView().ShowDialog();
        }
    }


}