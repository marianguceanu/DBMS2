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
        private readonly SqlConnection connectionString = new SqlConnection(@"Data Source=GUMCI\SQLEXPRESS;Initial Catalog=FightingGymDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
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

        private void classGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var classId = classGridView.Rows[e.RowIndex].Cells[0].Value;
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
    }
}
