using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();

        private void button2_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = textBox2.Text,
                CustomerSurname = textBox3.Text,
                CustomerCity = textBox4.Text,
                CustomerBalance = decimal.Parse(textBox5.Text),
                CustomerShoppingCount = int.Parse(textBox6.Text),
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Ekleme başarılı...","Uyarı");
        }
    }
}
