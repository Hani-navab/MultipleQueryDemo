using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultipleQueryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dsProduct.Product);
            // TODO: This line of code loads data into the 'dsSales.SalesOrderDetail' table. You can move, or remove it, as needed.
            this.salesOrderDetailTableAdapter.Fill(this.dsSales.SalesOrderDetail);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            salesOrderDetailTableAdapter.FillByProductID(dsSales.SalesOrderDetail, Convert.ToInt16(cboProduct.SelectedValue));
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            salesOrderDetailTableAdapter.FillByDate(dsSales.SalesOrderDetail, dtpStart.Value, dtpEnd.Value);
        }

        private void btnNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDiscount.Checked)
                salesOrderDetailTableAdapter.FillByDiscount(dsSales.SalesOrderDetail);
            else
                salesOrderDetailTableAdapter.FillByNoDiscount(dsSales.SalesOrderDetail);
        }
    }
}
