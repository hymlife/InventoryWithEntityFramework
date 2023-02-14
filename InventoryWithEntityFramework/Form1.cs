using Inventory.Business.Abstract;
using Inventory.Entities.Concrete;

namespace InventoryWithEntityFramework
{
    public partial class Form1 : Form
    {
        private readonly IDeviceInformationService _deviceInformationService;
        private int selectedId = 0;

        private void ClearTextBoxs()
        {
            selectedId = 0;
            txtBoxHardwareNo.Clear();
            txtBoxBrand.Clear();
            txtBoxModel.Clear();
            txtBoxSerialNo.Clear();
            txtBoxFaultStatus.Clear();
            txtBoxDate.Clear();
        }

        public Form1(IDeviceInformationService deviceInformationService)
        {
            InitializeComponent();
            _deviceInformationService = deviceInformationService;
        }

        public DeviceInformation GetDeviceInformation()
        {
            var device =  new DeviceInformation()
            {
                HardwareNo = txtBoxHardwareNo.Text,
                Brand = txtBoxBrand.Text,
                Model = txtBoxModel.Text,
                SerialNo = txtBoxSerialNo.Text,
                FaultStatus = txtBoxFaultStatus.Text,
                Date = txtBoxDate.Text,
            };
            if(selectedId != 0)
                device.Id = selectedId;
            return device;
        }

      

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtBoxHardwareNo.Text = row.Cells[1].Value.ToString();
                txtBoxBrand.Text = row.Cells[2].Value.ToString();
                txtBoxModel.Text = row.Cells[3].Value.ToString();
                txtBoxSerialNo.Text = row.Cells[4].Value.ToString();
                txtBoxFaultStatus.Text = row.Cells[5].Value.ToString();
                txtBoxDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _deviceInformationService.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
                MessageBox.Show("Seçili bir cihaz yok.");
            else
            {
                _deviceInformationService.Delete(GetDeviceInformation());
                dataGridView1.DataSource = _deviceInformationService.GetAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxHardwareNo.Text == String.Empty || txtBoxBrand.Text == String.Empty || txtBoxFaultStatus.Text == String.Empty || txtBoxModel.Text == String.Empty || txtBoxSerialNo.Text == String.Empty || txtBoxDate.Text == String.Empty)
            {
                MessageBox.Show("Lütfen alanlarý doldurunuz");
            }
            else
            {
                if (selectedId == 0)
                {
                    _deviceInformationService.Add(GetDeviceInformation());
                }
                else
                {
                    _deviceInformationService.Update(GetDeviceInformation());
                }
                dataGridView1.DataSource = _deviceInformationService.GetAll();
                ClearTextBoxs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearTextBoxs();
        }
    }
}