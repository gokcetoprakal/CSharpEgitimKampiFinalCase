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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrmFinalCase
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
        // en çok harcama yapılan kategori
            var mostSpendingCategory = db.Spendings
        .GroupBy(s => s.CategoryId)
        .Select(g => new
        {
            CategoryId = g.Key,
            TotalSpending = g.Sum(s => s.SpendingAmount) 
        })
        .OrderByDescending(x => x.TotalSpending)
        .FirstOrDefault();
            var mostCategoryName = db.Categories
                .Where(c => c.CategoryId == mostSpendingCategory.CategoryId)
                .Select(c => c.CategoryName) // Sadece ad sütununu seç
                .FirstOrDefault();
            lblMostSpendingCategory.Text = mostCategoryName;

            //en son harcama yapılan kategori
            var latestSpendingById = db.Spendings.OrderByDescending(s => s.SpendingId).FirstOrDefault();
            int latestCategoryId = (int)latestSpendingById.CategoryId;
            var lastCategoryName = db.Categories
            .Where(c => c.CategoryId == latestCategoryId)
            .Select(c => c.CategoryName)
            .FirstOrDefault();
            lblLastSpendingCategory.Text = lastCategoryName;

            //kategori sayısı
            var categoryCount = db.Categories.Count();
            lblTotalCategory.Text = categoryCount.ToString();

            //chart
            var spendingSummary = db.Spendings
        .GroupBy(s => s.CategoryId)
        .Select(g => new
        {
            CategoryId = g.Key,
            TotalSpending = g.Sum(s => s.SpendingAmount)
        })
        .ToList();
            var chartData = spendingSummary.Join(
                db.Categories,
                summary => summary.CategoryId,
                category => category.CategoryId,
                (summary, category) => new
                {
                    CategoryName = category.CategoryName, 
                    TotalAmount = summary.TotalSpending 
                })
                .ToList();

        
        chart1.Series.Clear();
            var series2 = chart1.Series.Add("Faturalar");
        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in chartData) {
            series2.Points.AddXY(item.CategoryName, item.TotalAmount);
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmTransactions frmTransactions = new FrmTransactions();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
