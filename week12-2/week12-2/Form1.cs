using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV File|*.csv";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ProductRepository repo = new ProductRepository();
                var list = repo.getProductsfromCSV(dialog.FileName);

                grid.DataSource = list;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGrid();

            initList();
        }

        private void initList()
        {
            listCategories.DataSource = GetCategories();
            listCategories.ValueMember = "id";
            listCategories.DisplayMember = "title";
        }

        private void initGrid()
        {
            DataGridViewColumn col;
            DataGridViewComboBoxColumn combocol;
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "ID";
            col.Name = "id";
            col.Width = 50;
            col.DataPropertyName = "id";
            grid.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Product Title";
            col.Name = "title";
            col.Width = 200;
            col.DataPropertyName = "title";
            grid.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Unit Price";
            col.Name = "price";
            col.Width = 80;
            col.DataPropertyName = "price";
            grid.Columns.Add(col);

            combocol = new DataGridViewComboBoxColumn();
            combocol.HeaderText = "Category";
            combocol.Name = "category";
            combocol.Width = 150;
            combocol.DataPropertyName = "catid";
            combocol.DataSource = GetCategories();
            combocol.ValueMember = "id";
            combocol.DisplayMember = "title";

            grid.Columns.Add(combocol);
        }

        private List<Category> GetCategories()
        {
            List<Category> items = new List<Category>();
            items.Add(new Category() { id = 1, title = "Kahvaltılık" });
            items.Add(new Category() { id = 2, title = "Atıştırmalık" });
            items.Add(new Category() { id = 3, title = "Mevye Sebze" });
            items.Add(new Category() { id = 4, title = "Temizlik Malzemesi" });

            return items;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV File|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ProductRepository repo = new ProductRepository();
                var list =(List<Product>) grid.DataSource;

                repo.saveProductstoCSV(dialog.FileName,list);
                System.Diagnostics.Process.Start(dialog.FileName);
            }
        }

        private void listCategories_MouseDown(object sender, MouseEventArgs e)
        {
            listCategories.DoDragDrop(listCategories.SelectedValue, DragDropEffects.Copy);
        }

        private void grid_DragOver(object sender, DragEventArgs e)
        {
            Point clientPoint = grid.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo info = grid.HitTest(clientPoint.X, clientPoint.Y);
            if(info.Type == DataGridViewHitTestType.Cell && grid.Columns[info.ColumnIndex].Name == "category")
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void grid_DragDrop(object sender, DragEventArgs e)
        {
            int item = (int)e.Data.GetData(typeof(System.Int32));
            Point clienPoint = grid.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo info = grid.HitTest(clienPoint.X, clienPoint.Y);
            if(info.Type == DataGridViewHitTestType.Cell)
            {
                if (grid.Columns[info.ColumnIndex].Name == "category")
                    grid.Rows[info.RowIndex].Cells[info.ColumnIndex].Value = item;
                MessageBox.Show("Data is " + item);
            }
        }
    }
}
