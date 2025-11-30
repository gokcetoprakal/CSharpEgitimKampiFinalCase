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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        int count = 0;
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " TL";

            var lastProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastProcessAmount.Text = lastProcessAmount.ToString() + " TL";

            //Chart 1 kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData) { 
            series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
            //Chart2 kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            });
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData) {
            series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 5 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + " TL";
            }
            else if (count % 5 == 2) {
                var suFaturasi= db.Bills.Where(x => x.BillTitle == "Su").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + " TL";
            }
            else if (count % 5 == 3) {
                var dogalGazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "DoğalGaz Faturası";
                lblBillAmount.Text = dogalGazFaturasi.ToString() + " TL";
            }
            else if (count % 5 == 4) {
                var cepTelFaturasi = db.Bills.Where(x => x.BillTitle == "Cep Telefonu").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Cep Telefonu Faturası";
                lblBillAmount.Text = cepTelFaturasi.ToString() + " TL";
            }
            else if (count % 5 == 0) {
                var evIntFaturasi = db.Bills.Where(x => x.BillTitle == "Ev İnterneti").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Ev İnterneti Faturası";
                lblBillAmount.Text = evIntFaturasi.ToString() + " TL";
            }

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories c = new FrmCategories();
            c.Show();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks b = new FrmBanks();
            b.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling b = new FrmBilling();
            b.Show();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmTransactions t = new FrmTransactions();
            t.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard d = new FrmDashboard();
            d.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings s = new FrmSettings();
            s.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
