using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI
{
    using BL.Abstract;
    using BL.Concrete;
    using DAL.Context;
    using Helper;
    

    public partial class CustomerListForm : Form
    {
        ICustomerBusiness customerBusiness;
        public CustomerListForm()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            FillColumnMapping();
            FillGrid();
        }
        private void FillColumnMapping()
        {
            grd.AutoGenerateColumns = false;
            grd.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CompanyName", "CompanyName", "Müşteri Adı"));
            grd.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ContactName", "ContactName", "İlgili Kişi"));
            grd.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ContactTitle", "ContactTitle", "İlgili Ünvan"));
            grd.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Phone", "Phone", "Telefon")); 
        }
        private void FillGrid()
        {
            grd.DataSource = null;
            var result = customerBusiness.Get();
            grd.DataSource = result;
        }


        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer=(grd.DataSource as List<Customer>)[e.RowIndex];
            var form = new Customer_Form();
            form.MdiParent = this.MdiParent;
            form.Tag = customer.CustomerID;
            form.FormClosed += Form_FormClosed;
            form.Show();

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }
    }
}
