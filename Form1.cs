using System.ComponentModel;
using System.Drawing.Text;

namespace Assignment3._4._1
{
    public partial class Form1 : Form
    {
        BindingList<Coffee> coffees = new BindingList<Coffee>();
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRoast.DataSource = Enum.GetValues(typeof(Roast));

            coffees.Add(new Coffee() { BevName = "Folgers", CRoast = Roast.light, IsDecaf = true, Price = 6.00, SizeOz = 12 });
            coffees.Add(new Coffee() { BevName = "Black Rifle", CRoast = Roast.medium, IsDecaf = false, Price = 7.00, SizeOz = 12 });

            dataGridView1.DataSource = coffees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double.TryParse(txtPrice.Text, out double price);
            double.TryParse(txtSizeOz.Text, out double sizeOz);
            Coffee coffee = new Coffee
            {
                BevName = txtBevName.Text,
                Price = price,
                SizeOz = sizeOz,
                CRoast = (Roast)cmbRoast.SelectedItem,
                IsDecaf = checkBox1.Checked
            };
            coffees.Add(coffee);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = coffees;

            txtBevName.Clear();
            txtPrice.Clear();
            txtSizeOz.Clear();
            cmbRoast.SelectedIndex = -1;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Coffee selectedCoffee = (Coffee)dataGridView1.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show($"Are you sure you want to delete {selectedCoffee.BevName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    coffees.Remove(selectedCoffee);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = coffees;
                }
            }
            else
            {
                MessageBox.Show("Please select a coffee to delete.");
            }
        }
    }
}
