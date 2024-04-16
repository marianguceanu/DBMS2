using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms1
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection connectionString = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FightingGymDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fightingGymDBDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.fightingGymDBDataSet.Class);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter.FillBy(this.fightingGymDBDataSet.Class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void updateMaterialsGridView(object classId)
        {
            string sqlCommand = "select * from Materials where cid=@id";

            // TODO, update sql connection in case of failure
            SqlCommand getMaterialsByClassId = new SqlCommand(sqlCommand, connectionString);
            getMaterialsByClassId.Parameters.AddWithValue("@id", classId);

            using (var ds = new DataSet())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(getMaterialsByClassId);

                adapter.Fill(ds, "Materials");

                materialsGrid.DataSource = ds.Tables["Materials"];
            }
        }

        private void classGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var classId = classGridView.Rows[e.RowIndex].Cells[0].Value;
            updateMaterialsGridView(classId);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var index = materialsGrid.Rows.Count-2; // Automatically inserts empty row
            var materialsName = materialsGrid.Rows[index].Cells[1].Value;
            var classId = classGridView.SelectedRows[0].Cells[0].Value;
            var price = materialsGrid.Rows[index].Cells[3].Value;
            var quantity = materialsGrid.Rows[index].Cells[4].Value;

            string sqlCommand = "insert into Materials (mname, cid, price, quant) values (@name, @cid, @price, @quant)";

            SqlCommand addMaterial = new SqlCommand(sqlCommand, connectionString);
            addMaterial.Parameters.AddWithValue("@name", materialsName);
            addMaterial.Parameters.AddWithValue("@cid", classId);
            addMaterial.Parameters.AddWithValue("@price", price);
            addMaterial.Parameters.AddWithValue("@quant", quantity);

            connectionString.Open();
            addMaterial.ExecuteNonQuery();
            connectionString.Close();
            updateMaterialsGridView(classId);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var index = materialsGrid.Rows.Count - 2; // Automatically inserts empty row
            var id = materialsGrid.Rows[index].Cells[0].Value;
            var materialsName = materialsGrid.Rows[index].Cells[1].Value;
            var classId = classGridView.SelectedRows[0].Cells[0].Value;
            var price = materialsGrid.Rows[index].Cells[3].Value;
            var quantity = materialsGrid.Rows[index].Cells[4].Value;

            string sqlCommand = "update Materials set mname = @name, cid = @cid, price = @price, quant = @quant where mid = @id";

            SqlCommand updateMaterial = new SqlCommand(sqlCommand, connectionString);
            updateMaterial.Parameters.AddWithValue("@id", id);
            updateMaterial.Parameters.AddWithValue("@name", materialsName);
            updateMaterial.Parameters.AddWithValue("@cid", classId);
            updateMaterial.Parameters.AddWithValue("@price", price);
            updateMaterial.Parameters.AddWithValue("@quant", quantity);

            connectionString.Open();
            updateMaterial.ExecuteNonQuery();
            connectionString.Close();
            updateMaterialsGridView(classId);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = materialsGrid.SelectedRows[0].Cells[0].Value;
            var classId = classGridView.SelectedRows[0].Cells[0].Value;
            string sqlCommand = "delete from Materials where mid = @id";
            SqlCommand deleteMaterial = new SqlCommand( sqlCommand, connectionString);
            deleteMaterial.Parameters.AddWithValue("@id", id);

            connectionString.Open();
            deleteMaterial.ExecuteNonQuery();
            connectionString.Close();
            updateMaterialsGridView(classId);
        }
    }
}
