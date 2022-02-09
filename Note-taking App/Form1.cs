using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_taking_App
{
    public partial class Form1 : Form
    {
        DataTable DataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable = new DataTable();
            DataTable.Columns.Add("Title", typeof(String));
            DataTable.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = DataTable;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 183;

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTit.Clear();
            txtMsg.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Add(txtTit.Text, txtMsg.Text);

            txtTit.Clear();
            txtMsg.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int point = dataGridView1.CurrentCell.RowIndex;

            if (point > -1)
            {
                txtTit.Text = DataTable.Rows[point].ItemArray[0].ToString();
                txtMsg.Text = DataTable.Rows[point].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int point = dataGridView1.CurrentCell.RowIndex;

            DataTable.Rows[point].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}