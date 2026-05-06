namespace App_Inmobiliaria
{
    public partial class Form1 : Form
    {
        List<Property> properties = new List<Property>();

        private void SetupDgv()
        {
            dgvProperties.ColumnCount = 6;
            dgvProperties.Columns[0].Name = "Vendedor";
            dgvProperties.Columns[1].Name = "Cliente";
            dgvProperties.Columns[2].Name = "Direccion";
            dgvProperties.Columns[3].Name = "Tipo de bien";
            dgvProperties.Columns[4].Name = "Venta total";
            dgvProperties.Columns[5].Name = "Renta total";

            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateDgvElements()
        {
            dgvProperties.Rows.Clear();
            // p to no repeat property
            foreach (Property p in properties)
            {
                dgvProperties.Rows.Add(
                    p.SellerName,
                    p.ClientName,
                    p.Address,
                    p.Type,
                    p.CalculateSale().ToString("C2"),
                    p.CalculateRent().ToString("C2")
                    );
            }
        }
        public Form1()
        {
            InitializeComponent();
            SetupDgv();
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Arrays for every property model
            string[] luxuryModels = { "Cosmopolitan", "Venecia" };
            string[] commercialModels = { "Torreon", "Gomez Palacio" };
            string[] landModels = { "Residencial", "Comercial" };

            cmbPropertyModel.Enabled = true;

            // Fill cmbPropertyModel from arrays
            switch (cmbTypes.Text)
            {
                case "Lujo":
                    cmbPropertyModel.DataSource = luxuryModels;
                    break;
                case "Comerciales":
                    cmbPropertyModel.DataSource = commercialModels;
                    break;
                case "Terrenos":
                    cmbPropertyModel.DataSource = landModels;
                    break;
            }
        }

        private void btnRegisterAndCalculate_Click(object sender, EventArgs e)
        {
            Property property = PropertyFactory.Create(cmbTypes.Text, txtSellerName.Text, txtClientName.Text, txtAddress.Text, cmbPropertyModel.Text,
                int.Parse(txtMonths.Text), double.Parse(txtArea.Text), rbSale.Checked);

            properties.Add(property);
            UpdateDgvElements();
        }

        private void rbSale_CheckedChanged(object sender, EventArgs e)
        {
            txtMonths.Enabled = false;
            txtArea.Enabled = false;
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            txtMonths.Enabled = true;
            txtArea.Enabled = true;
        }
    }
}
