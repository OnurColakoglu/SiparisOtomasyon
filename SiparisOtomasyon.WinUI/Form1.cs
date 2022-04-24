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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newCustomerMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(new Customer_Form());
        }

        private void CustomerListMenuItem_Click(object sender, EventArgs e)
        {

            this.ShowMdiForm(new CustomerListForm());

        }

        public void ShowMdiForm(Form form)
        {
            CheckOpenForm();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();

        }
        public void CheckOpenForm()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].MdiParent!=null)
                {
                    Application.OpenForms[i].Close();
                    i--;
                }
            }

        }

        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(new ProductForm());
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(new ProductListForm());
        }
    }
}   
