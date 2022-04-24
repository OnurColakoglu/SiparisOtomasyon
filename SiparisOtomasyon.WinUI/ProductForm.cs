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
    using DAL.Context;
    using Helper;
    using BL.Abstract;
    using BL.Concrete;
    public partial class ProductForm : Form
    {
        ICategoryBusiness categoryBusiness;
        ISupplierBusiness supplierBusiness;
        IProductBusiness productBusiness;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillData();
        }

        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id>0)
            {
                var product = productBusiness.GetById(id);
                if (product!=null)
                {
                    this.selectedProduct = product;
                    txtProductName.Text = product.ProductName;
                    txtQuantityPerUnit.Text = product.QuantityPerUnit;
                    cmbCategory.SetSelectedValue(product.CategoryID);
                    cmbSupplier.SetSelectedValue(product.SupplierID);
                    chkIsDiscountinued.Checked = product.Discontinued;
                    nuReorderLEvel.Value = Convert.ToDecimal(product.ReorderLevel);
                    nuPrice.Value = Convert.ToDecimal(product.UnitPrice);
                    nuUnitsonOrder.Value = Convert.ToDecimal(product.UnitsOnOrder);
                    nuUnitsInStock.Value = Convert.ToDecimal(product.UnitsInStock);

                }
            }

        }
        private void FillControl()
        {
            FillCategory();
            FillSupplier();
        }

        private void FillSupplier()
        {
            //var suppliers = supplierBusiness.Get();
            //cmbSupplier.DisplayMember = "CompanyName";
            //cmbSupplier.ValueMember = "SupplierID";
            //cmbSupplier.DataSource = suppliers;
        }

        private void FillCategory()
        {
            //var categories = categoryBusiness.Get();
            //cmbSupplier.DisplayMember = "CategoryName";
            //cmbSupplier.ValueMember = "CategoryID";
            //cmbSupplier.DataSource = categories;
        }

        private void btnProductNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }
        Product selectedProduct;
        private void FormClear()
        {
            this.Tag = null;
            this.selectedProduct = null;
            UICoreUtility.FormClear(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
