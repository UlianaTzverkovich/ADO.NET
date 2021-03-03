using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;

namespace ZACHET4
{
    public partial class Form1 : Form
    {
        SampleContext context = new SampleContext();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    LastName = this.textBoxLastName.Text,
                    FirstName = this.textBoxFirstName.Text,
                    email = this.textBoxEmail.Text,
                    Orders = orderlistBox.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                textBoxLastName.Text = String.Empty;
                textBoxFirstName.Text = String.Empty;
                textBoxEmail.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }


        }
        private void Output()
        {
            if (this.radioButtonCustomer.Checked == true)
                dataGridView1.DataSource = context.Customers.ToList();
            else if (this.radioButtonOrder.Checked == true)
                dataGridView1.DataSource = context.Orders.ToList();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

            Output();
            var query = from b in context.Customers
                        orderby b.LastName
                        select b;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                OrderName = "ADO_DataSet_document",
                Size = 1.301,
                Price = 11
            });
            context.Orders.Add(new Order
            {
                OrderName = "ADO_LINQtoSQL_document",
                Size = 2.670,
                Price = 22
            });
            context.Orders.Add(new Order
            {
                OrderName = "ADO_NET_document",
                Size = 4.234,
                Price = 33
            });
            context.Orders.Add(new Order
            {
                OrderName = "ADO_NET_EF_document",
                Size = 8.760,
                Price = 44
            });
            context.Orders.Add(new Order
            {
                OrderName = "ADO_NET_Доступ к данным_document",
                Size = 4.128,
                Price = 55
            });
            context.SaveChanges();

        }
    }

}
