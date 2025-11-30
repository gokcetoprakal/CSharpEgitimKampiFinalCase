using FinancialCrmFinalCase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmFinalCase
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db =  new FinancialCrmDbEntities1();
        void ListBills()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            ListBills();
        }
        #region FATURA BUTONLAR
        private void btnBillGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            var values = db.Bills.Find(id);
            var listToShow = new List<Bills> { values };
            dataGridView1.DataSource = listToShow;
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.Bill_ID = id;
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            ListBills();
            MessageBox.Show("Ekleme başarılı");
            
        }

        private void btnBillUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            var values = db.Bills.Find(id);

            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            ListBills();
            MessageBox.Show("Düzenleme başarılı");
        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            ListBills();
            MessageBox.Show("Silme işlemi başarılı!");
        }
        #endregion

        #region BUTONLAR
        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories cat = new FrmCategories();
            cat.Show();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks bank = new FrmBanks();
            bank.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmTransactions frmTransactions = new FrmTransactions();
            frmTransactions.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
