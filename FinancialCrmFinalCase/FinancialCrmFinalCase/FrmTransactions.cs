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
    public partial class FrmTransactions : Form
    {
        public FrmTransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmTransactions_Load(object sender, EventArgs e)
        {
            #region PANELLER
            //son gelir
            var latestIncome = db.BankProcesses
            .Where(p => p.ArttiMi == true)
            .OrderByDescending(p => p.BankProcessId)
            .FirstOrDefault();
            lblLastIncome.Text = latestIncome.Amount.ToString() + " TL";

            //son gider
            var latestExpence = db.BankProcesses
           .Where(p => p.ArttiMi == false)
           .OrderByDescending(p => p.BankProcessId)
           .FirstOrDefault();
            lblLastExpence.Text = latestExpence.Amount.ToString() + " TL";

            //toplam gelir-gider
            decimal totalIncome = (decimal)db.BankProcesses
            .Sum(p => p.Amount);
            lblTotalIncome.Text = totalIncome.ToString();
            #endregion
            #region CHARTS
            //chart1
            var incomeData = db.BankProcesses.Where(p => p.ArttiMi == true).Select(x => new
            {
                x.Description,
                x.Amount
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in incomeData)
            {
                series.Points.AddXY(item.Description, item.Amount);
            }

            //chart2
            var expenceData = db.BankProcesses.Where(p => p.ArttiMi == false).Select(x => new
            {
                x.Description,
                x.Amount
            }).ToList();
            var series2 = chart2.Series.Add("Series2");
            foreach (var item in expenceData)
            {
                series2.Points.AddXY(item.Description, item.Amount);
            }
            #endregion

        }
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
