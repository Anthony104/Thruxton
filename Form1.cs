using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikes_Mock_Exam
{
    public partial class frmBikes : Form
    {
        public frmBikes()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int i, j;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikesDataSet3.mycycles' table. You can move, or remove it, as needed.
            this.mycyclesTableAdapter.Fill(this.bikesDataSet3.mycycles);
            dt.Columns.Add("Stock_ID", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("Make", typeof(string));
            dt.Columns.Add("Engine_Size", typeof(int));
            dt.Columns.Add("Colour", typeof(string));
            dt.Columns.Add("Date_Sold", typeof(string));
            dt.Columns.Add("Selling_Price", typeof(string));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.bikesDataSet3.RejectChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.mycyclesTableAdapter.Update(this.bikesDataSet3.mycycles);
         
        
        }

        private void aLLToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.ALL(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aLLToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.Sale(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void saleToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void all_For_SaleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.All_For_Sale(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void soldToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.Sold(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void all_For_Sale1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.All_For_Sale1(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ___500ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter.@__500(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _500grToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mycyclesTableAdapter._500gr(this.bikesDataSet3.mycycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mycyclesBindingSource.MoveFirst();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mycyclesBindingSource.MovePrevious();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mycyclesBindingSource.MoveNext();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mycyclesBindingSource.MoveLast();
        }
}

}
