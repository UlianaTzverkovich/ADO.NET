using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZACHET2
{
    public partial class Form1 : Form
    {
        private Panel advancedPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adwentureWorksDataSet1.Customers;
            sqlDataAdapter1.Fill(adwentureWorksDataSet1.Customers);
        }
        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(adwentureWorksDataSet1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }
    }
}
