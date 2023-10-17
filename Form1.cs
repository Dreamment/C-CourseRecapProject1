namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxFilterCategory.DataSource = context.Categories.ToList();
                cbxFilterCategory.DisplayMember = "CategoryName";
                cbxFilterCategory.ValueMember = "CategoryId";
            }
        }

        private void cbxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxFilterCategory.SelectedValue));
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a category");
                ListProducts();
            }
        }

        private void tbxFilterName_TextChanged(object sender, EventArgs e)
        {
            string key = tbxFilterName.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(key);
            }
        }
    }
}