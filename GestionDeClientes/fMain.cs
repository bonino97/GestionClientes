using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class formGestionDeC : Form
    {
        private CustomerManager _customerManager;

        public formGestionDeC()
        {
            InitializeComponent();
            Init();
        }

        private void formGestionDeC_Activated(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void Init()
        {
            _customerManager = new CustomerManager();
        }

        private void EditCustomer()
        {
            if(lstCustomer.SelectedIndices.Count == 0)
            {
                return;
            }

            int selectedIndex = lstCustomer.SelectedIndices[0];
            Customer customer = _customerManager.Customers[selectedIndex];

            fCustomer formCustomer = new fCustomer();
            formCustomer.EditingCustomer = new Customer()
            {
                Name = customer.Name,
                LastName = customer.LastName,
                Address = customer.Address
            };

            if(formCustomer.ShowDialog() == DialogResult.OK)
            {
                _customerManager.SetCustomer(selectedIndex,formCustomer.EditingCustomer);
                btnRefresh.PerformClick();
            }
        }

        private void DeleteCustomer()
        {
            if (lstCustomer.SelectedIndices.Count == 0)
            {
                return;
            }
            int selectedIndex = lstCustomer.SelectedIndices[0];
            _customerManager.DeleteCustomer(selectedIndex);
            btnRefresh.PerformClick();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstCustomer.Items.Clear();

            List<Customer> customers = _customerManager.Customers;

            foreach (Customer customer in customers)
            {
                ListViewItem item = lstCustomer.Items.Add(customer.Name);
                item.SubItems.Add(customer.LastName);
                item.SubItems.Add(customer.Address);

            }

            if(lstCustomer.Items.Count > 0)
            {
                lstCustomer.Items[0].Selected = true;
            }

            lblTotalCustomers.Text = "Total Clientes: " + _customerManager.Customers.Count;

            lstCustomer.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fCustomer formCustomer = new fCustomer();
            formCustomer.EditingCustomer = new Customer();

            if(formCustomer.ShowDialog() == DialogResult.OK){
                Customer newCustomer = formCustomer.EditingCustomer;
                _customerManager.AddCustomer(newCustomer.Name, newCustomer.LastName, newCustomer.Address);

                btnRefresh.PerformClick();
            }
        }

        private void lstCustomer_DoubleClick(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

    }
}
