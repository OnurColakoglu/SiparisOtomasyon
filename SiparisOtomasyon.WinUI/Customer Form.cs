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
    using BL.Concrete;
    using BL.Abstract;
    using SiparisOtomasyon.WinUI.Helper;
    using System.Collections;

    public partial class Customer_Form : Form
    {
        ICustomerBusiness customerBusiness;
        public Customer_Form()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            FillData();
        }
        Customer selectedCustomer=null;
        private void FillData()
        {
            string id = this.Tag?.ToString(); //this.tag nulldan farklıysa toString çalışsın demek
            if (!string.IsNullOrWhiteSpace(id))
            {
                this.selectedCustomer = customerBusiness.GetById(id);
                if (this.selectedCustomer!=null)
                {
                    txtCompanyName.Text = this.selectedCustomer.CompanyName;
                    txtContactName.Text = this.selectedCustomer.ContactName;
                    txtContactTitle.Text = this.selectedCustomer.ContactTitle;
                    txtPostalCode.Text = this.selectedCustomer.PostalCode;
                    txtPhone.Text = this.selectedCustomer.Phone;
                    txtFax.Text = this.selectedCustomer.Fax;
                    txtCountry.Text = this.selectedCustomer.Country;
                    txtCity.Text = this.selectedCustomer.City;
                    txtRegion.Text = this.selectedCustomer.Region;
                    txtAdress.Text = this.selectedCustomer.Address;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            this.Tag = null;
            this.selectedCustomer = null;
            UICoreUtility.FormClear(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            try
            {
                if (this.selectedCustomer == null)
                {
                    this.selectedCustomer = new Customer();
                    this.selectedCustomer.CustomerID = GenerateCustomerCode(5);
                }
                this.selectedCustomer.CompanyName = txtCompanyName.Text;
                this.selectedCustomer.ContactName = txtContactName.Text;
                this.selectedCustomer.ContactTitle = txtContactTitle.Text;
                this.selectedCustomer.PostalCode = txtPostalCode.Text;
                this.selectedCustomer.Phone = txtPhone.Text;
                this.selectedCustomer.Fax = txtFax.Text;
                this.selectedCustomer.Country = txtCountry.Text;
                this.selectedCustomer.City = txtCity.Text;
                this.selectedCustomer.Region = txtRegion.Text;
                this.selectedCustomer.Address = txtAdress.Text;

                string id = this.Tag?.ToString();
                if (!string.IsNullOrWhiteSpace(id))
                {
                    customerBusiness.Update(this.selectedCustomer);//taginde id varsa güncelleme
                }
                else
                {
                    customerBusiness.Add(this.selectedCustomer);//taginde id yoksa ekleme
                    this.Tag = this.selectedCustomer.CustomerID;
                }
                UICoreUtility.SuccessMessage("İşlem başarılı şekilde yapıldı");
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }
        static Random rnd = new Random();
        private string GenerateCustomerCode(int lengtH)
        {
            const string chars = "ABCDEFGHIJKLMNOPRSTUVYZQXW0123456789";
            return new string(Enumerable.Repeat(chars, lengtH).Select(t0 => t0[rnd.Next(t0.Length)]).ToArray());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            try
            {
                if (UICoreUtility.DialogMessage("Bu kaydı silmek istiyormusunuz?") == DialogResult.OK)
                {
                    if (customerBusiness.Delete(this.selectedCustomer.CustomerID))
                    {
                        UICoreUtility.SuccessMessage("Silme işlemi başarılı");
                        this.Close();
                    }
                    else
                    {
                        UICoreUtility.ErrorMessage("Silme işleminde bir hata oluştu.");
                    }
                }
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
